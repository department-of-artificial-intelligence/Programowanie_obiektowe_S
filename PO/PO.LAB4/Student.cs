using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.LAB4
{
    internal class Student
    {
        private static int id;


        public IList<FinalGrade> Grades
        { get; set; }

        public int Semester
        { get; set; }

        public int Group
        {
            get; set;
        }
        public int IndexId
        { get; set; }
        public string Specialization
        { get; set; }
        public double AverageGrades
        { get; set; }
        Student(string firstName , string lastName , DateTime dateOfBirth , string specjalization , int group , int semester)
        {
            semester = 1;
        }
        public override string ToString()
        {
            return "";
        }
    }
}
