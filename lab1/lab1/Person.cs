using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
    public class Person
    {
        private string[] _registrationNumber;
        private int _carsCount;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount { get => _carsCount; set => _carsCount = value; }
        public int MaxCarCount { get; set; }

        public Person()
        {
            FirstName = "nieznane";
            LastName = "nieznane";
            Address = "nieznany";
            _carsCount = 0;
            MaxCarCount = 3;
            _registrationNumber = new string[MaxCarCount];
        }
        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            _carsCount = 0;
            MaxCarCount = 3;
            _registrationNumber = new string[MaxCarCount];
        }
        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            _carsCount = 0;
            MaxCarCount = 3;
            _registrationNumber = new string[MaxCarCount];

            foreach (Car car in cars)
            {
                AddCarRegistrationNumber(car.RegistrationNumber);
            }
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (_carsCount < MaxCarCount)
            {
                for (int i = 0; i < _registrationNumber.Length; ++i)
                {
                    if (_registrationNumber[i] == null)
                    {
                        _registrationNumber[i] = registrationNumber;
                        _carsCount++;
                        Console.WriteLine($"Car with registration " + registrationNumber + $" added");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Registration list is full- new registration canot be added");
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            for (int i = 0; i < _registrationNumber.Length; ++i)
            {
                if (_registrationNumber[i] == registrationNumber)
                {
                    _registrationNumber[i] = null;
                    _carsCount--;
                    Console.WriteLine($"Car with registration " + registrationNumber + $" has been removed");
                    return;
                }
            }
            Console.WriteLine($"Cannot find car with registration {registrationNumber}");
        }

        public override string ToString()
        {
            string registrationList = "Registration numbers: ";
            foreach (string registration in _registrationNumber)
            {
                if (registration != null)
                {
                    registrationList += "\n" + registration;
                }
            }
            return $"Person: | First name {FirstName}, Last name {LastName}, Address {Address}, Cars: {registrationList}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}

