using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9klasy
{
    public class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }
        //public List<int> Grades { get; set; }
        public Student(string firstName, string surName, string faculty, int studentNo)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
        }

        public Student() { }
    }
}
