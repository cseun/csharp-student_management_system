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
        public static void LoadStudentScoresFromFile(string filePath)
        {
            var lines = File.ReadAllLines(filePath);

            StudentScoreManager.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                var cols = lines[i].Split(',');

                if (cols.Length < 12)
                    continue;

                if (!int.TryParse(cols[0], out int grade)) continue;
                if (!int.TryParse(cols[1], out int cls)) continue;
                if (!int.TryParse(cols[2], out int no)) continue;

                string name = cols[3];

                if (!int.TryParse(cols[4], out int year)) continue;
                if (!int.TryParse(cols[5], out int semester)) continue;

                if (!Enum.TryParse(cols[6], out ExamType examType))
                    continue;

                if (!int.TryParse(cols[7], out int kor)) continue;
                if (!int.TryParse(cols[8], out int eng)) continue;
                if (!int.TryParse(cols[9], out int math)) continue;
                if (!int.TryParse(cols[10], out int social)) continue;
                if (!int.TryParse(cols[11], out int science)) continue;

                Student student = new Student(
                    new StudentKey(grade, cls, no),
                    cols[0]
                );

                Exam exam = new Exam(year, semester, examType);

                Score score = new Score(
                    exam, kor, eng, math, social, science
                );

                StudentScore studentScore = new StudentScore(student, score);

                StudentScoreManager.AddStudentScore(studentScore);
            }
        }

        public static void SaveStudentScoresToFile(string filePath)
        {
            var list = StudentScoreManager.SearchStudentScores();

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(
                "Grade,Class,No,Name,Year,Semester,ExamType,Korean,English,Math,Social,Science"
            );
            foreach (var ss in list)
            {
                sb.AppendLine(string.Join(",",
                    ss.Student.Key.Grade,
                    ss.Student.Key.Class,
                    ss.Student.Key.No,
                    ss.Student.Name,
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
