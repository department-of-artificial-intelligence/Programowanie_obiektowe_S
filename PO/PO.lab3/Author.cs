using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal class Author : Person
    {
        public string Nationality { get; set; }

        public Author() {

            Nationality = "none";
        
        }

        public Author(string firstName, string lastName, string nationality)
            : base(firstName, lastName) { 
        
            Nationality = nationality;
        
        }

        public override string ToString()
        {

            return $"Author {base.ToString()}, Nationality {Nationality}";

        }
        
    }
}
