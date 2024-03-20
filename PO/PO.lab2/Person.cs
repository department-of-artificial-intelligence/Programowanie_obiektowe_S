using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab2
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;
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
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        public Person()
        {
            _firstName = string.Empty;
            _lastName = string.Empty;
            _dateOfBirth = DateTime.MinValue;
        }
        public Person(string firstName, string lastName, DateTime datofbirth)
        {
            _firstName=firstName;
            _lastName=lastName;
            _dateOfBirth = datofbirth;
        }
        public override string ToString()
        {
            return $"First Name: {_firstName}, Last Name: {_lastName}, Data of Birth: {_dateOfBirth}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    };
}
