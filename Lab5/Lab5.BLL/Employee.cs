using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;

namespace Lab5.BLL
{
    public class Employee: Generic.Extensions.IContainer
    {
        private string _fistName;
        private string _lastName;
        private DateTime _dateOfBirth;

        public string FirstName
        {
            get { return _fistName; }
            set { _fistName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public Employee(string fistName, string lastName, DateTime dateOfBirth)
        {
            _fistName = fistName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public Employee(Employee employee)
        {
            this._fistName = employee._fistName;
            this._lastName = employee._lastName;
            this._dateOfBirth = employee._dateOfBirth;
        }

        public void Print()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}, Date of Birth: {DateOfBirth.ToShortDateString()}");
        }
    }
}