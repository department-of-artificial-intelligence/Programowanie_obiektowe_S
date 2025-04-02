using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Student:Person
    {
        private int id;

        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group {  get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrade { get; set; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1) : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Specialization: {Specialization}, Group: {Group}, Semester: {Semester}";
        }
    }
}
