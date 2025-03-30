using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Author
    {
        public string Nationality
        {
            get; set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }
      

       

        public Author(string firstName, string lastName, string nationality)
        {
            Nationality = nationality;
            FirstName = firstName;
            LastName = lastName;
        }


        public override string ToString()
        {
            return base.ToString() + $", Nationality: {Nationality}";

        }



    }
}
