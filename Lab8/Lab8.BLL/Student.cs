using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName {  get; set; }
        public string SurName { get; set; }
        public string Faculty {  get; set; }
        public int StudentNo {  get; set; }
        public Student()
        {
            StudentNo = 0;
            FirstName = string.Empty;
            SurName = string.Empty;
            Faculty = string.Empty;
        }

        public Student(string firstName, string surName, string faculty, int studentNo)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
        }
    }
}
