using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public Person() { }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"imie: {FirstName}, nazwisko: {LastName}.";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }


    }
}
