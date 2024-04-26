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
        public IList<double> Grades { get; set; }
        public string GradesAsString
        {
            get
            {
                if (Grades != null)
                    return string.Join(", ", Grades);

                return "No Grades";
            }
        }
        public Student() 
        {
            FirstName= string.Empty;
            LastName= string.Empty;
            Faculty= string.Empty;
            StudentNo= 0;
            Grades = new List<double>();
        }
        public Student(string firstName, string lastName, string faculty, int studentNo) 
        {
            FirstName = firstName;
            LastName = lastName;
            Faculty = faculty;
            StudentNo = studentNo;
            Grades = new List<double>();
        }
    }
}
