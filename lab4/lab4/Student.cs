using lab4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Student : Person, IContainer, IDisplayable
    {
        public int Id = 1;
        public IList<FinalGrade> Grades { get; set; } = new List<FinalGrade>();
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades
        {
            get
            {
                double sum = 0.0;
                if (Grades != null)
                {
                    foreach (var grade in Grades)
                        sum += grade.Value;
                    return sum / Grades.Count;
                }
                return sum;
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
            string gradesStr = Grades != null && Grades.Count > 0
                ? "\n  " + string.Join("\n  ", Grades)
                : "Brak ocen";
            return $" Student: " + base.ToString() + $" {Specialization}, {Group}, {Semester}, \n  Grades: {gradesStr}";
        }
    }
}
