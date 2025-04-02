using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName = "none", string lastName = "none")
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"first name = {FirstName}, last name ={LastName}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
