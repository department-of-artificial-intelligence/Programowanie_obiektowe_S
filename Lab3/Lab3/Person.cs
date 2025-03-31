using System;
using System.Collections.Generic;
using System.Linq;
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
            FirstName = "nieznany";
            LastName = "nieznane";
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"Imie: {FirstName} Nazwisko: {LastName}";
        }
        public void Details()
        {
            Console.WriteLine(ToString() );
        }

    }
}
