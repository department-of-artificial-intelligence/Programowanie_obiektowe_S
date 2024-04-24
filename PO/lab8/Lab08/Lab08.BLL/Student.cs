using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.BLL
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Faculty {  get; set; }
        public int StudentNumber { get; set; }
        public IList<Grade> Grades { get; set; }

        public Student(string firstName, string lastName, string faculty, int studentNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Faculty = faculty;
            StudentNumber = studentNumber;
            Grades = new List<Grade>();
        }
        public Student() {
            FirstName = "NoName";
            LastName = "NoSurname";
            Faculty = "NoFaculty";
            StudentNumber = 0;
            Grades = new List<Grade> { };
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, Faculty: {Faculty}, Student No: {StudentNumber}";
        }
    }
}
