using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_Przygotowanie
{
    internal class Person
    {

        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName { get { return _firstName; } set {  _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public DateTime DateOfBirth { get { return _dateOfBirth; } set { _dateOfBirth = value; } }

        public Person() {

            _firstName = "none";
            _lastName = "none";
            _dateOfBirth = DateTime.Now;

        }

        public Person(string firstName, string lastName, DateTime dateOfBirth) { 
        
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        
        }

        public override string ToString() {

            return $"FirstName: {_firstName}, LastName {_lastName}, DateTime {_dateOfBirth}";
        
        }

        public void Details() {

            Console.WriteLine(ToString());

        }


    }
}
