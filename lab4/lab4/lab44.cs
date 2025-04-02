using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04 {
    class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirt { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, DateTime dateOfBirt) {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirt = dateOfBirt;
        }

        public override string ToString() {
            return $"first name {FirstName} last name" +
                $" {LastName} dta urodzenia {DateOfBirt} tyle ";
        }
    }


}
