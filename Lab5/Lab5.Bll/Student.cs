using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Bll
{
    public class Student : Person
    {
        private static int _id;

        public IList<FinalGrade> Gradess { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specjalization { get; set; }
        public double AverageGrades { get; set; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specjalization, int group, int semester = 1) : base(firstName, lastName, dateOfBirth)
        {
            Specjalization = specjalization;
            Group = group;
            Semester = semester;
            Gradess = new List<FinalGrade>();
        }
        public override string ToString()
        {
            return base.ToString() + $" Specjalization: {Specjalization} Grupa: {Group} Semester: {Semester}";
        }

    }
}
