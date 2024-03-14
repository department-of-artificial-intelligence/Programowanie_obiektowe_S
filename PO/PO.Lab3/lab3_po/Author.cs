using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public class Author
    {
        public string _firstName;
        public string _lastName;
        public string _nationality;

        public Author() 
        {
            _firstName = "";
            _lastName = "";
            _nationality = "";
        }

        public Author(string firstName, string lastName, string nationality)
        {
            _firstName = firstName;
            _lastName = lastName;
            _nationality = nationality;
        }

        public override string ToString()
        {
            return $"First name: {_firstName}, last name: {_lastName}, nationality: {_nationality}";
        }
    }
}
