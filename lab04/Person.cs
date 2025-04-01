using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName, string lastName, DateTime dateOfBrith) 
        { 
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBrith;
        }

        public override string ToString()
        {
            return$"Person | FirstName: {FirstName}, LastNaem {LastName}, DateOfBirtg: {DateOfBirth}\n";
        }
    }
}
