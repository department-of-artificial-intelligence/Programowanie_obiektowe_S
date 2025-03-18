using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Author
    {
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Nationality
        {
            get;
            set;
        }

        public Author()
        {
            FirstName = "nieznane";
            LastName = "nieznane";
            Nationality = "nieznane";
        }

        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"Author: | FirstName: {FirstName}, LastName: {LastName}, Nationality: {Nationality}";
        }
    }
}
