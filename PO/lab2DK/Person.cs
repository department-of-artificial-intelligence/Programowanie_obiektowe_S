using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2DK
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
            _firstName = "None";
            _lastName = "None";
            _dateOfBirth = new DateTime();
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return _firstName + " " + _lastName + " " + _dateOfBirth.ToString();
        }
        public virtual void Details()
        {
            Console.WriteLine(this.ToString() + "\n");
        }
    }
}
