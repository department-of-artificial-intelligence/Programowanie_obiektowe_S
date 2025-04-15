using System;
using System.Collections.Generic;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Employee : IContainer, IDisplayable
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName
        {
            get => _firstName; set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName; set => _lastName = value;
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth; set => _dateOfBirth = value;
        }

        public Employee(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName ?? string.Empty;
            LastName = lastName ?? string.Empty;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}";
        }
    }
}