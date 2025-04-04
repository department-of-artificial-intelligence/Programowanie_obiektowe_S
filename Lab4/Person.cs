using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string firstName = "NONE", string lastName = "NONE", DateTime dateOfBirth = default(DateTime))
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"name = {FirstName}, last name = {LastName}, B-date = {DateOfBirth}";
        }


    }
}
