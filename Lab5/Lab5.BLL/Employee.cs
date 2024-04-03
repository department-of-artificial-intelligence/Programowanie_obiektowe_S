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
        private int _numberOfCages;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int NumberOfCages { get => _numberOfCages; set => _numberOfCages = value; }

        public Employee(string firstName, string lastName, int numberOfCages) 
        {
            _firstName = firstName;
            _lastName = lastName;
            _numberOfCages = numberOfCages;
        }

        public override string ToString()
        {
            var str = $"First name: {FirstName}, last name: {LastName}, number of cages: {NumberOfCages}";
            return str;
        }
    }
}