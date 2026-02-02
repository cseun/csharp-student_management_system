using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public enum StudentStatus
    {
        Studying,   // 재학중
        Graduated,  // 졸업
        Break       // 휴학
    }

    public record StudentKey(string School, int Grade, int Class, int No);
    public class Student
    {
        public StudentKey Key { get; }
        public string Name { get; set; }
        public StudentStatus Status { get; set; }
        public string? ImagePath { get; set; }

        public Student(
            StudentKey key, 
            string name,
            StudentStatus status,
            string? imagePath = null)
        {
            Key = key;
            Name = name;
            Status = status;
            ImagePath = imagePath;
        }

        public bool HasSameKey(Student other)
        {
            return Key.Equals(other.Key);
        }

        public override string ToString()
        {
            return $"{Key.Grade}-{Key.Class}-{Key.No} {Name}";
        }
    }
}
