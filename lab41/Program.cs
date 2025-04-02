using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab41 {
    internal class Program {
        static void Main(string[] args) {
            Person person = new Person("Grzegorz",
                "Brzęćzyszczykiewicz", new DateTime(2001, 09, 11));

            Console.WriteLine(person);


        }
    }
}