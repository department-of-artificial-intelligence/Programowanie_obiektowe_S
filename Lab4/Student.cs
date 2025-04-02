using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Student : Person
    {
        private static readonly int id;

        public IList<FinalGrade> Grades { get; set; }
        public int Semester {  get; set; }
        public int Group {  get; set; }
        public int IndexId { get; set; }
        public string? Specialization { get; set; }
        public double AverageGrades {
            get
            {
                double sum = 0.0;

                foreach(var grade in Grades)
                {
                    sum += grade.Value;
                }

                return sum / Grades.Count;
            }
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
        }
        public override string ToString()
        {
            string wynik = base.ToString();

            wynik += $"\nSemester: {Semester}\nGroup: {Group}\nIndex id: {IndexId}\nSpecialization: {Specialization}\nGroup: {Group}\nSemester: {Semester}";

            wynik = wynik + "\nGrades:\n";

            foreach(var grade in Grades)
            {
                wynik += grade.ToString() + '\n';
            }

            wynik += $"Average of grades: {AverageGrades}";

            return wynik;
        }
    }
}
