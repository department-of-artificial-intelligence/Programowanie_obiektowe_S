using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName { 
            get { return _firstName; } 
            set {  _firstName = value; } 
        }
        public string LastName { 
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
            _firstName = "nieznane";
            _lastName = "nieznane";
            _dateOfBirth = DateTime.Now;
        }
        public Person(string firstName, string lastName, DateTime DateOfBirth)
        {

            _firstName = firstName;
            _lastName = lastName; 
            _dateOfBirth = DateOfBirth;
        }
        public override string ToString()
        {
            return $"Imie: {_firstName}, nazwisko: {_lastName}," +
                $"urodzony: {_dateOfBirth}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}