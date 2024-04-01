using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Employee
    {
        public string Name{ get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Employee() { }
        public Employee(string name, string lastName, DateTime dateOfBirth)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"{Name} {LastName} {DateOfBirth} ";
        }
    }
}