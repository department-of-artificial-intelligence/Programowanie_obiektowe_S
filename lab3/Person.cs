using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Person
    {
        public string Firtsname { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            Firtsname = "nieznane";
            LastName = "nieznane";
        }
        
        public Person(string firtsname, string lastName)
        {
            Firtsname = firtsname;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Person | Firtsname: {Firtsname}, LastName {LastName}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
