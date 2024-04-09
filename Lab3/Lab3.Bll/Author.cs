using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Bll
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public Author() { FirstName = string.Empty;LastName = string.Empty;Nationality = string.Empty; }
        public Author(string firstname,string lastname, string nationality) {
            FirstName = firstname;
            LastName = lastname;
            Nationality = nationality;
        }
        public override string ToString()
        {
            string tmp = base.ToString() + $", {FirstName} {LastName} {Nationality} ";
            return tmp;
        }
    }
}
