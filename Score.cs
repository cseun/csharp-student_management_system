using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public enum ExamType
    {
        Midterm,
        Final,
        MidFinal
    }

    public record Exam(int Year, int Semester, ExamType ExamType);
    public class Score
    {
        public Exam Exam { get; set; }
        public int Kor { get; set; }
        public int Eng { get; set; }
        public int Math { get; set; }
        public int Social { get; set; }
        public int Science { get; set; }
        public int TotalScore => Kor + Eng + Math + Social + Science;

        public Score(Exam exam, int kor, int eng, int math, int social, int science)
        {
            Exam = exam;
            Kor = kor;
            Eng = eng;
            Math = math;
            Social = social;
            Science = science;
        }

        public bool IsSameExam(Exam exam)
        {
            return Exam.Equals(exam);
        }
    }
}
