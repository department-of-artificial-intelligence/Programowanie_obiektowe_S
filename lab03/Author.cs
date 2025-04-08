using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Author:Person
    {
        
        public string Nationality { get; set; }

        public Author():base() { }

        public Author(string firstname, string lastname, string nationality):base(firstname,lastname)
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
