using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Lab3
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
            return $"FirstName: {FirstName}, LastName: {LastName}, Nationality: {Nationality}";
        }
    }
}
