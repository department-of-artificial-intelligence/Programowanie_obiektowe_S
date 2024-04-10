using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() {

            FirstName = "none";
            LastName = "none";
        
        }

        public Person(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;

        }

        public override string ToString()
        {

            return $" FirstName {FirstName}, LastName {LastName}";

        }

        public void Details() {

            Console.WriteLine(ToString());

        }
    }
}
