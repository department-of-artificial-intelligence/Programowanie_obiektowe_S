using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
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
            _firstName = "Unknown";
            _lastName = "Unknown";
            _dateOfBirth = new DateTime(01/01/2000);
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public virtual void Details()
        {
            Console.WriteLine($"Person: {_firstName} {_lastName}, BirthDate: {_dateOfBirth}");
        }

        public override string ToString()
        {
            return $"Person: {_firstName} {_lastName}, BirthDate: {_dateOfBirth}";
        }
    }
}
