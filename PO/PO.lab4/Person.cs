using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab4
{
    internal abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public Person(string firstName, string lastName, DateTime dateofBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
        }
        public override string ToString()
        {
            return $"Person| First Name {FirstName} Last Name {LastName} Date Of Birth {DateofBirth}";
        }
    }
}
