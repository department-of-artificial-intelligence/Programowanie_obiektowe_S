using Generic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.bll
{
    public class Employee : IContainer, IDisplayable
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public Employee(string firstName,string lastName,DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

    }
}