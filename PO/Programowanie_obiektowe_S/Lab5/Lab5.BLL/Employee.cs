using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Employee
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfDirth;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateOfBirth { get => _dateOfDirth; set => _dateOfDirth = value; }

        public Employee() { }
        public Employee(string name, string sur, DateTime DOB)
        {
            FirstName = name;
            LastName = sur;
            DateOfBirth = DOB;
        }
        public override string ToString()
        {
            return $"Employee: {FirstName} | {LastName} | {DateOfBirth.ToString("yyyy.MM.dd")}";
        }
    }
}