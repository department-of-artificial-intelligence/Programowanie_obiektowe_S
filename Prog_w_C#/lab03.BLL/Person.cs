using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03.BLL
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        { 
            FirstName = string.Empty;
            LastName = string.Empty;
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
    }
}
