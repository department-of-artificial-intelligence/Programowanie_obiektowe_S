using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.BLL
{
    public class Student
    {
        private string _firstName;
        private string _surName;
        private string _faculty;
        private int _studentNo;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
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
        public int StudentNo
        {
            get { return _studentNo; }
            set { _studentNo = value; }
        }

        public Student()
        {
            _firstName = string.Empty;
            _surName = string.Empty;
            _faculty = string.Empty;
            _studentNo = 0;
        }

        public Student(string firstName, string surName, string faculty, int studentNo)
        {
            _firstName = firstName;
            _surName = surName;
            _faculty = faculty;
            _studentNo = studentNo;
        }
    }
}
