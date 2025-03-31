using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Author:Person
    {

        public string Nationality { get; set; }
        public Author():base()
        { 
            FirstName = "brakimienia";
            LastName = "braknazwiska";
            Nationality = "braknarodowosci";

        }

        public Author(string firstName, string lastName,string nationality):base(firstName,lastName)
        {
            FirstName=firstName;
            LastName=lastName;
            Nationality=nationality;
        }
        public override string ToString()
        {
            return base.ToString()+$" Panstwo: {Nationality} ";
        }

    }
}
