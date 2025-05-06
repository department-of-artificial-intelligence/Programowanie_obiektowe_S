using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private string?[] _registrationNumbers;

        public static int MaxCarCount { get; set; } = 3;
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public int CarsCount {  get; set; }
        public Person() {
            _registrationNumbers = new string[3];            
            FirstName = "unknown";
            LastName = "unknown";
            Address = "unknown";
            CarsCount = 0;
        }

        public Person(string firstName,  string lastName,string address)
        {
            _registrationNumbers = new string[3];            
            FirstName = firstName;
            LastName=lastName;
            Address = address;
            CarsCount = 0;
        }

        public Person(string firstName, string lastName,string address, Car[] cars)
        {
            _registrationNumbers = new string[3];

            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CarsCount = 0;

        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (CarsCount < MaxCarCount)
            {
                _registrationNumbers[CarsCount] = registrationNumber;
                CarsCount++;
                Console.WriteLine($"Added {registrationNumber} to {FirstName} {LastName}.");
            }
            else {
                Console.WriteLine($"Not added {registrationNumber} to {FirstName} {LastName}, person has 3 cars already.");
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            for (int i= 0; i < _registrationNumbers.Length; i++)
            {
                if (_registrationNumbers[i] == registrationNumber)
                {
                    CarsCount--;
                    _registrationNumbers[CarsCount] = null;
                    
                    return;
                }
            }
            Console.WriteLine($"{FirstName} {LastName} -> {registrationNumber}, this person doesn't own this car!");
            return;

        }

        public override string ToString()
        {
            string temp = $"Person >> FirstName: {FirstName}, LastName: {LastName}, Address: {Address}, CarsCount: {CarsCount}";
            if (CarsCount > 0) temp += ", Cars: ";
            foreach (string? car in _registrationNumbers)
            {
                if (car != null)
                {
                    temp += car + ", ";
                }
            }
            return temp;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

    }
}
