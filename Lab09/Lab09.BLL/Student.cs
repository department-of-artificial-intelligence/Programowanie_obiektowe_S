using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.BLL
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int IndexNumber { get; set; }
        public string Faculty { get; set; }
        public Student() { 
            Name = string.Empty;
            Surname = string.Empty;
            IndexNumber = 0;
            Faculty = string.Empty;
        }
        public Student(string name, string surname, int indexNumber, string faculty)
        {
            Name = name;
            Surname = surname;
            IndexNumber = indexNumber;
            Faculty = faculty;
        }
    }
}
