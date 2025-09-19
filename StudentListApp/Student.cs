using System;

namespace StudentListApp
{
    public class Student
    {
        public string Name { get; set; }
        public int Semester { get; set; }
        public string CourseName { get; set; }

        public Student(string name, int semester, string courseName)
        {
            Name = name;
            Semester = semester;
            CourseName = courseName;
        }

        public override string ToString()
        {
            return $"{Name,-20} | {Semester,-5} | {CourseName,-10}";
        }
    }
}
