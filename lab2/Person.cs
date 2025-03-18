using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }

        public Person()
        {
            string _firstName = "nieznane";
            string _lastName = "nieznane";
            DateTime _dateOfBirth = DateTime.Now;
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            string dateOfBirthString = _dateOfBirth.ToString("dd-MM-yyyy");
            return $"Person: | Name: {_firstName}, Last name: {_lastName}, Date of birth: {dateOfBirthString}";
        }

        public virtual void Details()
        {
            Console.WriteLine(ToString());
        }

    }
}
