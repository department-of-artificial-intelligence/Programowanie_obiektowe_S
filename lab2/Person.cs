using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }

        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }


        public Person(string  firstName = "none", string lastName = "none", DateTime dateOfBirth = default(DateTime))
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"name = {_firstName}, lastname = {_lastName}, date of birth = {_dateOfBirth}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this);
        }


    }
}
