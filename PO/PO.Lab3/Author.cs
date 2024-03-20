using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public class Author : Person
    {
        public string Nationality {  get; set; }
        public Author()
        :base()
        {
            Nationality = "";
        }

        public Author(string firstName, string lastName, string nationality)
        :base(firstName, lastName)
        {
            Nationality = nationality;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"nationality: {Nationality}";
            return str;
        }
    }
}