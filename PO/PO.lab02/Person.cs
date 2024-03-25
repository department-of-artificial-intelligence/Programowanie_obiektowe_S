using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab02
{
    public class Person
    {
        protected string _firstName = null!;
        protected string _lastName = null!;
        protected DateTime _dateOfBirth;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public Person()
        {
            _firstName = "No name";
            _lastName = "No surname";
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
            return $"First name: {_firstName} | Last name: {_lastName} | Birthday: {_dateOfBirth}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
