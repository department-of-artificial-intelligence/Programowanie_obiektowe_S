using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uni
{
    public class Student : Person
    {
        public List<FinalGrade> Grades { get; set; } = new List<FinalGrade>();
        public int Semester {  get; set; }
        public int Group {  get; set; }
        public int IndexId { get; set; }
        public string Specialization { get; set; }
        public double AverageGrades => Grades.Count > 0 ? Grades.Average(g => g.Value) : 0; 
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1) : base(firstName, lastName, dateOfBirth)
        {
            Group = group;
            Semester=semester;
            Specialization=specialization;
        }
    }
    
}
