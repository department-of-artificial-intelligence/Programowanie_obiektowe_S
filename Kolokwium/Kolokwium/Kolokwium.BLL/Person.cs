using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    internal class Person : IInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"First Name: {FirstName} LastName: {LastName}";
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
