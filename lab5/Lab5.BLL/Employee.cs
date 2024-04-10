using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Employee : IDisplayable, IContainer
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Employee() 
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            DateOfBirth = DateTime.MinValue;
        }
        public Employee(string name, string lastName, DateTime dateOfBirth)
        {
            FirstName = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {DateOfBirth} ";
        }
    }
}