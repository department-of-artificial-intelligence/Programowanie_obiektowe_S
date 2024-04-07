using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab04
{
    public class Student : Person
    {
        private static int _id = 0;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set;  }
        public double AverageGrades { get; set; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1) 
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
            IndexId = _id++;
        }
        public override string ToString()
        {
            string str = base.ToString();
            str += Grades.ToString();
            str += $" | Semester: {Semester} | Group: {Group} | Id: {_id} | Specilization: {Specialization} | Average grades: {AverageGrades}";
            return str;
        }
    }
}
