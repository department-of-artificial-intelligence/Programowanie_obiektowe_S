using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Lab2
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

        public Person() 
        {
            _firstName = "";
            _lastName = "";
            _dateOfBirth = DateTime.MinValue;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public override string ToString() { return $"FirstName: {_firstName}, LastName: {_lastName}, DateOfBirth: {_dateOfBirth}"; }

        public virtual void Details() { Console.WriteLine(ToString());  }

    }
}
