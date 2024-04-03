using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.LAB4
{
    internal abstract class  Person
    {
        public string FirstName
        { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        Person(string firstName, string lastName, DateTime DateOfBirth)
        {
            
        }
        public override string ToString()
        {
            return "";
        }
    }
}
