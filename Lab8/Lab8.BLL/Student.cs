using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student
    {
        private string _firstName;
        private string _surName;
        private string _faculty;
        private int _studentNo;

        public string FirstName
        {
            get => _firstName; set => _firstName = value;
        }
        public string SurName
        {
            get => _surName; set => _surName = value;
        }
        public string Faculty
        { 
            get => _faculty; set => _faculty = value;
        }
        public int StudentNo
        {
            get => _studentNo; set => _studentNo = value;
        }
        public Student()
        {
            FirstName = "none";
            SurName = "none";
            Faculty = "none";
            StudentNo = 0;
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
