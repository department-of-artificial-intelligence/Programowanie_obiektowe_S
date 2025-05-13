using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab8.bll
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public int StudNo {  get; set; }

        public IList<int> Grades { get; set; }

        public Student() 
        {
            FirstName = "none";
            LastName = "none";
            Faculty = "none";
            StudNo = 0;
            Grades = new List<int>();
            
        }

        public Student(string firstName = "brak", string lastName = "brak", string faculty = "brak", int studNo = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Faculty = faculty;
            StudNo = studNo;
            Grades = new List<int>();
        }
    }
}
