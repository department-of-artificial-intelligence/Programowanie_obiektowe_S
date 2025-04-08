using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5.BLL
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private System.DateTime _dateOfBirth;

        public Employee(string firstName, string lastName, System.DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }
    }
}