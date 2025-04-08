using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }

        public Author (string firstName, string lastName, string nationality)
        {
            _firstName = firstName;
            _lastName = lastName;
            _nationality = nationality;
        }

        public override string ToString()
        {
            return $"Author | First Name: {_firstName}, Last name: {_lastName}, Nationality: {_natiobality}";
        }
    }
}
