using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
    public class Student
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Faculty { get; set; }
        public int StudentNo { get; set; }

        

        public Student()
        {
            FirstName = string.Empty;
            Surname = string.Empty;
            Faculty = string.Empty;
            StudentNo = 0;
            
        }
    }
}
