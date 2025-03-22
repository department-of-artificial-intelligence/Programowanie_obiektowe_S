using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Author:Person
    {
       
        public string Nationality { get; set; }

        public Author() :base() {
            Nationality = "nieznana";
        }

        public Author(string firtsname, string lastName, string nationality): base(firtsname, lastName)
        {

            Nationality = nationality;
        }

        public override string ToString()
        {
            return base.ToString() + $", Nationality: {Nationality}";
        }
    }
}
