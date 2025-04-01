using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Student : Person
    {
        private int id;

        public IList<FinalGrade> Grades { get; set; }   

        public int Semester { get; set; }

        public int Group { get; set; }

        public int IndexId { get; set; }

        public string Specialization { get; set; }

        public double AverageGrades { get; }

    /*    public Student()
        {
            Semester = 1;
            Group = 1;
            IndexId = 1;
            Specialization = "A";
           

            }
                */
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specialization, int group, int semester = 1) : base (firstName, lastName, dateOfBirth) {
        Specialization = specialization;
        Group = group;
        Semester = semester;

        }
        public override string ToString()
        {
            return $"Student | Specialization: {Specialization}, Group: {Group}, Semester: {Semester}";
        }



    }
}
