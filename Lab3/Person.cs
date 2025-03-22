using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public Person()
        {
            FirstName = "No first name";
            LastName = "No last name";
        }

        public Person(string? firstName, string? lastName)
        {
            FirstName = firstName ?? "No first name";
            LastName = lastName ?? "No last name";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
