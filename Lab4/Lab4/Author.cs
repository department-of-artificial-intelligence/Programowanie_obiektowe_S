using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Author
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Nationality {  get; set; }

        public Author(): base() 
        {
            Nationality = "nieznana";
        }
        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"Author | FirstName: {FirstName}, LastName: {LastName}, Nationality: {Nationality}";
        }
    }
}
