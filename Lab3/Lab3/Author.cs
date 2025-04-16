using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Author : Person
    {
        public string? Nationality { get; set; }

        public Author()
        {
			Nationality = "Author default nationality";
        }

		public Author(string firstName, string lastName, string nationality) : base(firstName, lastName)
		{
			Nationality = nationality;
		}

		public override string ToString()
		{
			return base.ToString() + $"Author`s nationality: {Nationality}\n\n";
		}
	}
}
