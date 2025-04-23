using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student
    {
        private string? _firstname;
        private string? _surname;
        private string? _faculty;
        private int _studentNo;

        public string? Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string? Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string? Faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }

        public int StudentNo {
            get { return _studentNo; }
            set { _studentNo = value; }
        }

        public Student(string firstname, string surname, string faculty, int studentNo) {
            Firstname = firstname ?? string.Empty;
            Surname = surname ?? string.Empty;
            Faculty = faculty ?? string.Empty;
            StudentNo = studentNo;
        }

        public Student()
        {
            Firstname = string.Empty;
            Surname = string.Empty;
            Faculty = string.Empty;
            StudentNo = 0;
        }
    }
}
