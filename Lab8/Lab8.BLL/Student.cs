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

        public int StudentNo
        {
            get { return _studentNo; }
            set { _studentNo = value; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value?? string.Empty; }
        }
        public string SurName
        {
            get { return _surName; }
            set { _surName = value; }
        }
        public string Faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }

        public Student(string firstName, string surName, string faculty, int studentNo)
        {
            FirstName = firstName;
            SurName = surName;
            Faculty = faculty;
            StudentNo = studentNo;
        }

        public Student()
        {
            FirstName = "none";
            SurName = "none";
            Faculty = "none";
            StudentNo = 0;
        }
    }
}
