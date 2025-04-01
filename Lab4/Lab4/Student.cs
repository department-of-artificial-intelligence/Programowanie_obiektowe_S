using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Student:Person
    {
        private int _id;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group { get; set; }
        public int IndexId { get { return _id; } set { _id = value; } }
        public string Specialization { get; set; }
        public double AverageGrades { get; }
        public Student(string firstName,string lastName,DateTime dateofBirth,string specialization, int group,int semester=1):base(firstName,lastName,dateofBirth)
        {
            Grades = new List<FinalGrade>();
            Specialization = specialization;
            Group= group;
            Semester= semester;
        }
        public override string ToString()
        {
            return $"Student: "+base.ToString()+$"Specjalizacja: {Specialization} Grupa: {Group} Semester: {Semester}";
        }
    }
}
