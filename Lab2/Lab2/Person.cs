using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            get => _firstName; set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName; set => _lastName = value;
        }
        public DateTime DateOfBirth
        {
            get => _dateOfBirth; set => _dateOfBirth = value;
        }
        public Person()
        {
            _firstName = "none";
            _lastName = "none";
            _dateOfBirth = default;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }
        public override string ToString() => $"{FirstName} {LastName} {DateOfBirth}";
        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}