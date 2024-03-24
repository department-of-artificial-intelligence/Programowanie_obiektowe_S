using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab01
{
    public class Person
    {
        private string _registrationNumber = null!;

        public static int MaxCarCount {  get => 3; set => value = 3; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount { get; set; }
        Person()
        {
            FirstName = "No name";
            LastName = "No surname";
            Address = "No address";
            CarsCount = 0;
        }
        Person(string firstName,  string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }
        Person(string firstName, string lastName, string address, Car []cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

    }
}
