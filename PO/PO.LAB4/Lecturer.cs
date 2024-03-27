using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.LAB4
{
    internal class Lecturer
    {
        public string AcademicTitle
        { get; set; }
        public string Position
        {  get; set; }
        Lecturer(string firstName , string lastName , DateTime dateOfBirth) 
        { }
        public override string ToString()
        {
            return "";
        }
    }
}
