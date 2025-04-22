using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Author : Person
    {
        public string Nationality { get; set; }
        public Author() : base()
        {
            Nationality = "no nationality";
        }
        public Author(string firstName, string lastName, string nationality)
            : base(firstName, lastName)
        {
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {Nationality}";
        }
    }
}
