using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab44 {
    internal class Program {
        static void Main(string[] args) {
            // Creating a person object
            Person person = new Person("Grzegorz",
                "Brzęczyszczykiewicz", new DateTime(2001, 09, 11));

            // Printing the person's details
            Console.WriteLine(person);

            // Creating a subject object
            Subject subject = new Subject("Mathematics", "Mathematics Specialization", 1, 30);

            // Printing the subject's details
            Console.WriteLine(subject);

            // Creating a final grade object
            FinalGrade finalGrade = new FinalGrade(subject, 95.5, DateTime.Now);

            // Printing the final grade details
            Console.WriteLine(finalGrade);
        }
    }
}