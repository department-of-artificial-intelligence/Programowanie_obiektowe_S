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
        public IList<FinalGrade> Grades { get => Grades; set => Grades = value; }
        public int Semester { get => Semester; set => Semester = value; }
        public int Group { get => Group; set => Group = value; }
        public int IndexId { get =>  _id; set => _id = value;}
        public string Specialization { get => Specialization; set => Specialization = value; }
        public double AverageGrades { get => AverageGrades; set => AverageGrades = value;}
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester) 
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
            IndexId = _id++;
            Grades = new IList<FinalGrade>();
        }
    }
}
