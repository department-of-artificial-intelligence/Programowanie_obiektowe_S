using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public Person() 
        { 
            FirstName = string.Empty; 
            LastName = string.Empty; 
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} ";
        }
        public void Details() 
        {
            Console.WriteLine(this);
        }
    }
}
