using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przygotowanie.BLL
{
    public class Person : IInfo
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            var str = $"First name: {FirstName}, last name: {LastName}";
            return str;
        }

        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
