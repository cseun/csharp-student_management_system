using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentManagementApp
{
    public class FileManager
    {
        public record LoadResult(int SuccessCount, int FailCount);

        public static LoadResult LoadStudentScoresFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);

            StudentScoreManager.Clear();

            int success = 0;
            int fail = 0;

            for (int i = 1; i < lines.Length; i++)
            {
                try
                {
                    var cols = lines[i].Split(',');

                    if (cols.Length < 15)
                        throw new Exception();

                    string school = cols[0];
                    string name = cols[4];
                    string? imagePath = string.IsNullOrWhiteSpace(cols[6]) ? null : cols[6];

                    if (!int.TryParse(cols[1], out int grade)) throw new Exception();
                    if (!int.TryParse(cols[2], out int cls)) throw new Exception();
                    if (!int.TryParse(cols[3], out int no)) throw new Exception();

                    if (!Enum.TryParse(cols[5], out StudentStatus status))
                        throw new Exception();

                    if (!int.TryParse(cols[7], out int year)) throw new Exception();
                    if (!int.TryParse(cols[8], out int semester)) throw new Exception();

                    if (!Enum.TryParse(cols[9], out ExamType examType))
                        throw new Exception();

                    if (!int.TryParse(cols[10], out int kor)) throw new Exception();
                    if (!int.TryParse(cols[11], out int eng)) throw new Exception();
                    if (!int.TryParse(cols[12], out int math)) throw new Exception();
                    if (!int.TryParse(cols[13], out int social)) throw new Exception();
                    if (!int.TryParse(cols[14], out int science)) throw new Exception();

                    if (imagePath != null && !File.Exists(imagePath))
                    {
                        imagePath = null; // 없으면 그냥 이미지 없음 처리
                    }

                    Student student = new Student(
                        new StudentKey(school, grade, cls, no),
                        name,
                        status,
                        imagePath
                    );

                    Exam exam = new Exam(year, semester, examType);

                    Score score = new Score(
                        exam, kor, eng, math, social, science
                    );

                    StudentScore studentScore = new StudentScore(student, score);

                    if (!StudentScoreManager.AddStudentScore(studentScore))
                        throw new Exception(); // 중복

                    success++;
                }
                catch
                {
                    fail++;
                }
            }

            return new LoadResult(success, fail);
        }

        public static void SaveStudentScoresToFile(string filePath)
        {
            var list = StudentScoreManager.SearchStudentScores();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(
                "School,Grade,Class,No,Name,Status,ImagePath,Year,Semester,ExamType,Korean,English,Math,Social,Science"
            );
            foreach (var ss in list)
            {
                sb.AppendLine(string.Join(",",
                    ss.Student.Key.School,
                    ss.Student.Key.Grade,
                    ss.Student.Key.Class,
                    ss.Student.Key.No,
                    ss.Student.Name,
                    ss.Student.Status,
                    ss.Student.ImagePath ?? "",
                    ss.Score.Exam.Year,
                    ss.Score.Exam.Semester,
                    ss.Score.Exam.ExamType,
                    ss.Score.Kor,
                    ss.Score.Eng,
                    ss.Score.Math,
                    ss.Score.Social,
                    ss.Score.Science
                ));
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }
    }
}
