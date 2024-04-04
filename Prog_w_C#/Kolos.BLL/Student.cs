using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos.BLL
{
    public class Student : Person
    {
        private static int _id;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester {  get; set; }
        public int Group {  get; set; }
        public int IndexId {  get; set; }
        public string Specjalization { get; set; }
        public double AverageGrades { get; set; }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specjalization,  int group, int semester) : base(firstName, lastName, dateOfBirth)
        {
            Specjalization = specjalization;
            Group = group;
            Semester = semester;
            Grades = new List<FinalGrade>();
        }
        public override string ToString()
        {
            return $"{base.ToString()},Spcjalizacja: {Specjalization} , Grupa: {Group} , Semester: {Semester} ";
        }
    }
}
