using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab3
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() 
        {
            FirstName = null;
            LastName = null;
        }
        public Person(string firstName,string lastName) 
        { 
            FirstName=firstName;
            LastName=lastName;
        }
        public override string ToString()
        {
            return $"Fisrt name:{FirstName}, Last Name: {LastName}";
        }
        public void Details()
        { 
            Console.WriteLine(this.ToString());
        }
    }
}
