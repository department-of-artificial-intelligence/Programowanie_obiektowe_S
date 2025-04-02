using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public class Author: Person
    {

        public string Nationality { get; set; }

        public Author(string fName, string lName, string nationality)
            :base(fName, lName)
        {
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Nationality: {Nationality}";
        }
    }
}