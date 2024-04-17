using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    public abstract class Person : IDisplay
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOFBirth { get; set; }
        public Person(string firstName, string lastName, DateTime dateOFBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOFBirth = dateOFBirth;
        }
        public override string ToString() 
        {
            return $"Imie:{FirstName} Nazwisko:{LastName} Data urodzenia:{DateOFBirth}";
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
