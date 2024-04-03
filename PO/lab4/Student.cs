using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Student : Person, IContainer, IDisplayable
    {
        private static int id = 1;
        public IList<FinalGrade> Grades {  get; set; }
        public int Semester {  get; set; }
        public int Group {  get; set; }
        public int IndexId {  get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get; }
        public Student(string firstName, string lastName, DateTime dateOfBirth
            , string specialization, int group, int semester = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Grades = new List<FinalGrade>();
            Specialization = specialization;
            Group = group;
            Semester = semester;
            id++;
        }
        public override string ToString()
        {
            return "Student | " + base.ToString() + $", Specialization: {Specialization}, ";
        }
    }
}
