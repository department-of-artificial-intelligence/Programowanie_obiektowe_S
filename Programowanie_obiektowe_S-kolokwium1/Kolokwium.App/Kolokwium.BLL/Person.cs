using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public abstract class Person : IDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            var str = $"First name: {FirstName}, last name: {LastName}, date of birth: {DateOfBirth} ";
            return str;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
