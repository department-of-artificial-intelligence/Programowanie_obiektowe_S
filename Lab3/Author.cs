using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Author
    {
        public  string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }

        public Author(string fName, string lName, string nationality)
        {
            FirstName = fName;
            LastName = lName;
            Nationality = nationality;

        }

        public override string ToString() 
        {
            return $"first name: {FirstName}, last name: {LastName}, Nationality: {Nationality}";
        }
    }
}
