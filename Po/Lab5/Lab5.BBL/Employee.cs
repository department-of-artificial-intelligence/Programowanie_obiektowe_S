using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BBL
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateT { get; set; }
        public DateTime DateN { get; set; }
        public Employee(string firstName, string lastName, DateTime dateTime) 
        {
            FirstName = firstName;
            LastName = lastName;
            DateT = dateTime;
          
        }
        public Employee(string firstName, string lastName, DateTime dateTime,DateTime dateN) 
        {
            FirstName = firstName;
            LastName = lastName;
            DateT = dateTime;
            DateN = dateN;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}, Last Name: {LastName}, Hire Date {DateT}, Date Now: {DateN}";
        }
    }
}