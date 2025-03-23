using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Author : Person
    {
        public string Nationality { get; set; }
        public Author() : base()
        {
            Nationality = "Unknown";
        }
        public Author(string firstName, string lastName, string nationality) : base(firstName, lastName)
        {
            Nationality = nationality ?? "Unknown";
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Nationality}";
        }
    }
}