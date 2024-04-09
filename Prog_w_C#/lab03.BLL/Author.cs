using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03.BLL
{
    public class Author : Person
    {
        
        public string Natianality { get; set; }
        public Author() : base()
        {
            Natianality = string.Empty;
        }
        public Author(string firstName, string lastName, string nationality) : base(firstName,lastName)
        { 
            Natianality = nationality;
        }
        public override string ToString() 
        {
            return $"Imie: {FirstName} Nazwisko: {LastName} Kraj pochodzenia: {Natianality}";
        }
    }
}
