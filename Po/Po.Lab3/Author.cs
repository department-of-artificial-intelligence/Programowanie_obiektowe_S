using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab3
{
    internal class Author : Person
    {
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        public string Nationality { get; set; }

        public Author() 
        { 
            FirstName = null;
            LastName = null;
            Nationality = null;
        }
        public Author(string firstName,string lastName,
            string nationality): base(firstName,lastName)
        { 
           
            Nationality = nationality;
        }
        public override string ToString()
        {
            return base.ToString()+$"Nationality: {Nationality}";
        }
    }
}
