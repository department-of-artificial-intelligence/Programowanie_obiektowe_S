using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Author
    {
        public string Firtsname { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }

        public Author() :base() {
            Firtsname = "nieznane";
            LastName = "nieznane";
            Nationality = "nieznana";
        }

        public Author(string firtsname, string lastName, string nationality)
        {
            Firtsname = firtsname;
            LastName = lastName;
            Nationality = nationality;
        }

        public override string ToString()
        {
            return base.ToString() + $",Firtsname: {Firtsname}, LastName {LastName},  Nationality: {Nationality}";
        }
    }
}
