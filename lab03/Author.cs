using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Author
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Nationality { get; set; }

        public Author() { }

        public Author(string firstname, string lastname, string nationality)
        {
            FirstName = firstname;
            LastName = lastname;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"imie: {FirstName}, nazwisko: {LastName}, nacja: {Nationality}.";
        }



    }
}
