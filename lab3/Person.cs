using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    public class Person {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person() {
        }

        public Person(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() {
            return $"First Name: {this.FirstName}, " +
                   $"Last Name: {this.LastName}";
        }

    }
}
