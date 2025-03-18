using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "unknown";
            LastName = "unknown";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
