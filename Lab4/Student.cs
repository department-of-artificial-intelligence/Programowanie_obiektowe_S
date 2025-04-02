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
        private static int id = 1;

        public IList<FinalGrade> Grades { get; set; }
        public int Semester {  get; set; }
        public int Group {  get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades {
            get
            {
                double sum = 0.0;

                if (Grades != null)
                {
                    foreach (var grade in Grades)
                    {
                        sum += grade.Value;
                    }

                    return sum / Grades.Count;
                }

                return 0.0;
            }
        }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
            IndexId = id;
            ++id;
        }
        public override string ToString()
        {
            string wynik = base.ToString();

            wynik += $", Specialization: {Specialization}, Group: {Group}, Semester: {Semester}, Index id: {IndexId}";

            wynik = wynik + "\nGrades:";
            if (Grades != null)
            {
                foreach (var grade in Grades)
                {
                    wynik += " " + grade;
                }
            }

            wynik += $"\nAverage of grades: {AverageGrades}";

            return wynik;
        }
    }
}
