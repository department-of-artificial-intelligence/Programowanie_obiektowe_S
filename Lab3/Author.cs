using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Nationality { get; set; }

        public Author()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
            Nationality = "Unknown";
        }

        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName ?? "Unknown";
            LastName = lastName ?? "Unknown";
            Nationality = nationality ?? "Unknown";
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Nationality}";
        }
    }
}
