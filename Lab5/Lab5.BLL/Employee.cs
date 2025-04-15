using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Generic.Extensions;
namespace Lab5.BLL
{
    public class Employee: IDisplayable
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

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }
}