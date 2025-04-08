using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    internal class Student : Person
    {
        static int _id;
        public IList<FinalGrade> Grades { get; set; } = new List<FinalGrade>();
        public int Semester {  get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get => (double)(Grades?.Sum(x => x.Value) ?? 0) / (Grades?.Count ?? 1); }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1) : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }
        public override string ToString()
        {
            return base.ToString() + $", Semester: {Semester}, Group: {Group}, IndexId: {IndexId}, Specialization: {Specialization}, AverageGrades: {AverageGrades}";
        }
    }
}
