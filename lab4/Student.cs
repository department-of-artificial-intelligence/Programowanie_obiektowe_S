using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Student : Person
    {
        private int _id;

        public IList<FinalGrade> Grades { get; set; } = new List<FinalGrade>();
        public int Semester { get; set; }
        public int Group {  get; set; }
        public int IndexId{ get; set; }
        public string Specialization {  get; set; }
        public double AverageGrades
        {
            get
            {
                double suma = 0.0;

                if (Grades!= null)
                {
                    foreach(var grade in Grades)
                    {
                        suma += grade.Value;
                    }
                    return suma / Grades.Count;
                }
                return 0.0;
            }
        }

        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester =1)
            : base(firstName, lastName, dateOfBirth)
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
            IndexId = _id;
        }

        public override string ToString()
        {
            string zwrot = base.ToString() + $"{Specialization}, {Group}, {Semester}, Grades: ";
            if (Grades!= null)
            {
                foreach (var grade in Grades)
                {
                    zwrot += " " + grade;
                }
            }
            zwrot += $" Average grade: {AverageGrades}";
            return zwrot;
        }
    }
}
