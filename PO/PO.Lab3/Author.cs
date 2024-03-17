using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab3
{
    public class Author : Person
    {
        public string Nationality { get; set; }
        public Author()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Nationality = string.Empty;
        }
        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"Author : {FirstName} \\ {LastName} \\ {Nationality}";
        }
    }
}
