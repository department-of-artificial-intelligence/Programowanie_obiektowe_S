using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Person
    {
        private string[] _registrationNumbers;
        //private int _carCount

        public static int MaxCarCount { get; set; } = 3;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount { get; set; }
        public Person()
        {
            _registrationNumbers = new string[MaxCarCount];
            FirstName = "nieznane";
            LastName = "nieznane";
            Address = "nieznane";
            CarsCount = 0;
        }

        public Person(string firstName, string lastName, string address)
        {
            _registrationNumbers = new string[MaxCarCount];
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CarsCount = 0;
        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            _registrationNumbers = new string[MaxCarCount];
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CarsCount = 0;

            foreach(Car car in cars)
            {
                AddCarRegistrationNumber(car.RegistrationNumber);
            }
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if(CarsCount >= MaxCarCount)
            {
                Console.WriteLine("This person has a maximum number of cars!");
                return;
            }
            else
            {
                for (int i = 0; i < _registrationNumbers.Length; i++)
                {
                    if (_registrationNumbers[i] == null)
                    {
                        _registrationNumbers[i]  = registrationNumber;
                        CarsCount++;
                        Console.WriteLine("Car added!");
                        return;
                    }
                }   
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            for (int i = 0; i < _registrationNumbers.Length; i++)
            {
                if (_registrationNumbers[i] == registrationNumber)
                {
                    CarsCount--;
                    _registrationNumbers[i] = null;
                    return;
                }
                Console.WriteLine("This person doesn't own this car!");
                return;
            }
        }

        public override string ToString()
        {
            string temp = $"Person| FirstName: {FirstName}, LastName: {LastName}, Address: {Address}, CarsCount: {CarsCount}";
            if (CarsCount > 0) temp += ", Cars:\n";
            foreach(string? car in _registrationNumbers)
            {
                if(car != null)
                {
                    temp += car + "\n";
                }
            }
            return temp;
        }

        public void Details()
        {
            Console.WriteLine(ToString());
        }
    }
}
