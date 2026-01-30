using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp
{
    public record StudentKey(int Grade, int Class, int No);
    public class Student
    {
        public StudentKey Key { get; }
        public string Name { get; set; }
        public Student(StudentKey key, string name)
        {
            Key = key;
            Name = name;
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
