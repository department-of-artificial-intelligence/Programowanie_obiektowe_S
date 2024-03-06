using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    public class Person
    {
        protected string _firstName, _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }

        public Person() { }
        public Person(string firstName, string lastName, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = date;
        }
        public virtual void Details()
        {
            Console.WriteLine($"Base Person: {ToString()}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {DateOfBirth.ToString("yyyy")}";
        }
    }
}
