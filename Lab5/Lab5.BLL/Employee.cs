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
        private DateTime _dateOfBirth;
        private int _numberOfCages;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int NumberOfCages { get => _numberOfCages; set => _numberOfCages = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

        public Employee(string firstName, string lastName, DateTime dateOfBirth, int numberOfCages) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            _numberOfCages = numberOfCages;
        }

        public override string ToString()
        {
            var str = $"First name: {FirstName}, last name: {LastName}, date of birth: {DateOfBirth} number of cages: {NumberOfCages}";
            return str;
        }
    }
}