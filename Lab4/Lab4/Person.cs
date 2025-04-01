using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person(string firstName,string lastName,DateTime dateofBirth) 
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateofBirth;
        }
        public override string ToString()
        {
            return $"Imie: {FirstName} Nazwisko: {LastName} Data Urodzenia: {DateOfBirth}";

        }
    }
}
