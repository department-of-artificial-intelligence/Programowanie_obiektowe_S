using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab4
{
    internal class Student : Person
    {
        private int id;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AvarageGrades { get 
            {
                if (Grades == null || Grades.Count == 0)
                {
                    return 0.0;
                }
                double sum = 0;
                foreach (var grade in Grades)
                {
                    sum += grade.Value;
                }
                return sum/Grades.Count;
            } }
        public Student(string firstName, string lastName, 
            DateTime dateOfBirth, string specialization, int group,int semester =1
            ) : base(firstName, lastName, dateOfBirth)
        {
         
            
            Semester = semester;
            Group = group;
            Specialization = specialization;
            Grades = new List<FinalGrade>();
            
        }
        
        public override string ToString()
        {
            string gradesName = Grades != null ? string.Join(", ", Grades.Select(a => a.ToString())) : "";

            return base.ToString() + $"Id: {IndexId}, Grades: {gradesName}," +
                $"Group: {Group}, Specialization: {Specialization}," +
                $" Average Grades: {AvarageGrades}";
        }
    }
}
