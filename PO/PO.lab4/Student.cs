using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    internal class Student : Person
    {
        private static int _id;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId {  get; set; }
        public string Specialization {  get; set; }
        public double AverageGrades { get;}
        public Student(string firstName, string lastName, DateTime dateofBirth, string specialization, int group, int semester = 1) : base(firstName, lastName, dateofBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }

        public override string ToString()
        {
            return $"STUDENT |{base.ToString()} | Specialization {Specialization} Group {Group} Semester {Semester}";
        }
    }
}
