using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLab8.BLL
{
    public class Student
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }   
        public string Faculty {  get; set; }
        public int StudentNo { get; set; }
        public Student() { }
        public Student(string firstName, string lastName, string faculty, int studentNo) 
        {
            FirstName = firstName;
            LastName = lastName;
            Faculty = faculty;
            StudentNo = studentNo;
        }
    }
}
