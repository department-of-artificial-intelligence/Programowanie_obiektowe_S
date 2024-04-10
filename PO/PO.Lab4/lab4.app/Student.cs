using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.app
{
    internal class Student : Person
    {
        private static int _id;
        public IList<FinalGrade> Grades { get; set; }
        public int Semestr { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades { get; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semestr) : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semestr = semestr;
            Grades = new List<FinalGrade>();
        }

        public override string ToString()
        {
            string s = new string($"Student | " + base.ToString() + $"Index ID: {IndexId} Semestr: {Semestr} Group: {Group} Specialization: {Specialization} Average Grades: {AverageGrades} Grades: \n");
            foreach (var item in Grades)
            {
                s += item.ToString();
            }

            return s;
        }
    }
}
