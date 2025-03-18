using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Author : Person
    {
        public string Nationality { get; set; }
        public Author(string firstName, string lastName, string nationality): base(firstName, lastName)
        {
            Nationality = nationality;
        }
        public Author(): this(string.Empty, string.Empty, string.Empty) { }
        public override string ToString()
        {
            return base.ToString()+$", Nationality: {Nationality}";
        }

    }
}
