using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public Person()
        {
            _firstName = "brak";
            _lastName = "brak";
            _dateOfBirth = default(DateTime);
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
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

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth;  }
            set { _dateOfBirth = value; }
        }

        public override string ToString()
        {
            return $"Person | FirstName: {_firstName}, LastName: {_lastName}, DateOfBirth: {_dateOfBirth}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
