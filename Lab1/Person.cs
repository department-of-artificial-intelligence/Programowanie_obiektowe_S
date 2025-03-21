using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        private string[] _registrationNumbers;
        private int _carsCount;
        public int MaxCarCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public int CarsCount
        {
            get { return _carsCount; }
            set { _carsCount = value; }
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (_carsCount >= MaxCarCount)
            {
                Console.WriteLine("Cant add another car, limit reached!");
            }
            else
            {
                _registrationNumbers[_carsCount] = registrationNumber;
                _carsCount++;
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Theres no cars to remove!");
            }
            else
            {
                for (int i = 0; i < _carsCount; i++)
                {
                    if (_registrationNumbers[i] == registrationNumber)
                    {
                        _registrationNumbers[i] = null;
                        _carsCount--;
                        Console.WriteLine($"Car {registrationNumber} has been removed from {FirstName}{LastName}'s garage");
                    }
                }
                Console.WriteLine($"Car with {registrationNumber} registration number not found");
            }

        }
        public Person()
        {
            FirstName = "none";
            LastName = "none";
            Address = "none";
            MaxCarCount = 3;
            _carsCount = 0;
            _registrationNumbers = new string[MaxCarCount];
        }

        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            MaxCarCount = 3;
            CarsCount = 0;
            _registrationNumbers = new string[MaxCarCount];
        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            MaxCarCount = 3;
            _registrationNumbers = new string[MaxCarCount];
            _carsCount = 0;

            foreach (Car car in cars)
            {
                AddCarRegistrationNumber(car.RegistrationNumber);
            }
        }
        public override string ToString()
        {
            string result = $"Person | First name: {FirstName}, Last name: {LastName}, Address: {Address} \n";

            if (_carsCount > 0)
            {
                result += "Cars: ";
                for (int i = 0; i < _carsCount; i++)
                {
                    result += $"{_registrationNumbers[i]} \n";
                }
            }
            return result;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

    }
}
