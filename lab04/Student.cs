using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Student : Person
    {
        private int id;

        public IList<FinalGrade> Grades { get; set; }
        public int Semestr { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AvrageGrades { get; }

        public Student (string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semestr = 1) :
            base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semestr = semestr;
        }

        public override string ToString()
        {
            string temp = "Grades | ";
            foreach(FinalGrade grade in Grades) temp += grade.ToString();
            return "Strudents | " + temp + $"Semester: {Semestr}, Group: {Group}, " +
                $"IndexId: {IndexId}, Specialization {Specialization}, AvrageGrades {AvrageGrades}\n";
        }
    }
}
