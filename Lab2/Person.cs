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
            FirstName = "none";
            LastName = "none";
            DateOfBirth = DateTime.MinValue;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Person | First Name: {_firstName}, Last Name: {_lastName}, Date Of Birth: {_dateOfBirth}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }

    }
}
