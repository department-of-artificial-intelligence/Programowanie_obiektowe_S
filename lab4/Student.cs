using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Student: Person, IContainer, IDisplayable
    {
        private static int id = 1;
        public IList<FinalGrade> Grades { get; set; }
        public int Semester { get; set; }
        public int Group {  get; set; }
        public int IndexId { get; set; }   
        public string Specialization { get; set; }
        public double AverageGrades { get; }
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1):base(firstName, lastName, dateOfBirth) 
        {
            Specialization = specialization;
            Group = group;
            Semester = semester;
            IndexId = id;
            ++id;
        }
        public override string ToString()
        {
            string res = $", Specialization: {Specialization}, Group: {Group}, Semester: {Semester}, Index id: {IndexId}";
            if (Grades != null)
            {
                foreach (var grade in Grades)
                {
                    res += grade.ToString();
                }
            }
            return res + base.ToString();
        }
    }
}
