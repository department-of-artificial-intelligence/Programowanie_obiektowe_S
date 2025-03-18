using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName) 
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public Person(): this(string.Empty, string.Empty) { }
        public override string ToString() { return $"FirstName: {FirstName}, LastName: {LastName}"; }
        public void Details() { Console.WriteLine(this.ToString()); }
    }
}
