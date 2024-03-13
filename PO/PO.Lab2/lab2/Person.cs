using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        protected string _firstName = null!;
        protected string _lastName = null!;
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
        public DateTime DateTime
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public Person()
        {
            _firstName = "Nieznane";
            _lastName = "Nieznane";
            _dateOfBirth = new DateTime();
        }
        public Person(string FirstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = FirstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Firstname: {_firstName}, Lastname: {_lastName},Dateofbirth: {_dateOfBirth} ";
        }

        public virtual void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
