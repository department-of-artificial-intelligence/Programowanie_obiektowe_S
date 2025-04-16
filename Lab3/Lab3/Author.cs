using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Author
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nationality { get; set; }

        public Author()
        {
            FirstName = "Author default first name";
			LastName = "Author default last name";
			Nationality = "Author default nationality";
        }

		public Author(string firstName, string lastName, string nationality)
		{
			FirstName = firstName;
			LastName = lastName;
			Nationality = nationality;
		}

		public override string ToString()
		{
			return $"Author first name: {FirstName}\nLast name: {LastName}\nNationality: {Nationality}\n\n";
		}
	}
}
