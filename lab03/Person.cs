using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "brak";
            LastName = "brak";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Person | FirstName: {FirstName}, LastName: {LastName}";
        }

        public void Details() => this.ToString();
    }
}
