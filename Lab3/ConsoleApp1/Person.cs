using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;

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
        public DateTime DateOfBirth
        {
            get { return DateOfBirth; }
            set { DateOfBirth = value; }
        }

        public Person()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _dateOfBirth = DateTime.MinValue;
        }

        public Person(string firstName , string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
            
        }

        public override string ToString()
        {
            return $"Person | FirstName: {_firstName}, LastName: {_lastName}, DateOfBirth: {_dateOfBirth}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}
