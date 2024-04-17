using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public abstract class Person:IDisplay
    {
        string FirstName { get; set; }
        public string LastName { get; set; }
        DateTime DateOfBirth { get; set; }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}";
        }

        public virtual void Display()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
