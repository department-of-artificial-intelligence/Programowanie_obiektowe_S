using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person() {
            FirstName = "Kazmirz";
            LastName = "Brak";
            DateOfBirth = DateTime.Now;

        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {

            return $"Firstname | {FirstName}, Lastname | {LastName}, | DateOfBirth {DateOfBirth}";
        }


    }
}
