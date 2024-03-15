using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }

        public Author()
        {
            FirstName = "";
            LastName = "";
            Nationality = "";
        }

        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, last name: {LastName}, nationality: {Nationality}";
        }
    }
}