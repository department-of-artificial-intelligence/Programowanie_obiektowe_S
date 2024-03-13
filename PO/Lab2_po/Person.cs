using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_po
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }

        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }


        public Person()
        {
            _firstName = "";
            _lastName = "";
            _dateOfBirth = DateTime.Now;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"First name: {_firstName}, last name: {_lastName}, " +
                   $"date of birth: {_dateOfBirth},";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}
