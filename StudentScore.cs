using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public record StudentExamKey(StudentKey StudentKey, Exam Exam);
    public class StudentScore
    {
        public StudentExamKey Key { get; }
        public Student Student { get; }
        public Score Score { get; }
        public int Rank { get; set; }

        public StudentScore(Student student, Score score)
        {
            this.Student = student;
            this.Score = score;
            this.Key = new StudentExamKey(student.Key, this.Score.Exam);
        }
        public override string ToString()
        {
            Debug.WriteLine("=== StudentScoreInfo ===");
            Debug.WriteLine($"학생: {this.Student}");
            Debug.WriteLine($"이미지 주소: {this.Student.ImagePath}");
            Debug.WriteLine($"학교: {this.Student.Key.School}");
            Debug.WriteLine($"학년: {this.Student.Key.Grade}");
            Debug.WriteLine($"반: {this.Student.Key.Class}");
            Debug.WriteLine($"번호: {this.Student.Key.No}");
            Debug.WriteLine($"이름: {this.Student.Name}");
            Debug.WriteLine($"상태: {this.Student.Status}");

            Debug.WriteLine($"시험년도: {this.Score.Exam.Year}");
            Debug.WriteLine($"학기: {this.Score.Exam.Semester}");
            Debug.WriteLine($"시험종류: {this.Score.Exam.ExamType}");

            Debug.WriteLine($"국어: {this.Score.Kor}");
            Debug.WriteLine($"영어: {this.Score.Eng}");
            Debug.WriteLine($"수학: {this.Score.Math}");
            Debug.WriteLine($"사회: {this.Score.Social}");
            Debug.WriteLine($"과학: {this.Score.Science}");

            return $"{Student} / {Score.Exam} / 총점 {Score.TotalScore} / 석차 {Rank}";
        }
    }
}
