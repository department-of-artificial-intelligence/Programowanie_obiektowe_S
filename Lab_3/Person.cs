using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string Tostring()
        {
            return $"Firstname: {FirstName} ,LastName: {LastName}";
        }
        public void Details()
        {
            Console.WriteLine(Tostring());
        }
    }
}
