using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Author
    {
        protected string? _firstName;
        protected string? _lastName;
        protected string? _nationality;

        public string FirstName { get { return _firstName!; } set { _firstName = value; } }
        public string LastName { get { return _lastName!; } set { _lastName = value; } }
        public string Nationality { get { return _nationality!; } set { _nationality = value; } }

        public Author() {
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
            return $"FirstName={FirstName},LastName={LastName},Nationality={Nationality}";
        }
    }
}
