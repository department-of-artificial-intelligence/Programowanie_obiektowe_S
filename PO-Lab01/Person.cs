using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab01
{
    public class Person
    {
        //private Car[] cars;
        private string[] _registrationNumber;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount { get => _registrationNumber.Count(r => r != null); }
        public static int MaxCarCount { get; set; }

        public Person()
        {
            FirstName = "nieznany";
            LastName = "nieznany";
            Address = "nieznany";
            //CarsCount = 0;
            MaxCarCount = 3;
            _registrationNumber = new string[MaxCarCount];
        }
        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            //CarsCount = 0;
            MaxCarCount = 3;
            _registrationNumber = new string[MaxCarCount];
        }
        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            //CarsCount = 0;
            MaxCarCount = 3;
            _registrationNumber = new string[MaxCarCount];

            foreach (Car car in cars)
            {
                AddCarRegistrationNumber(car.RegistrationNumber);
            }
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (CarsCount < MaxCarCount)
            {
                for (int i = 0; i < _registrationNumber.Length; ++i)
                {
                    if (_registrationNumber[i] == null)
                    {
                        _registrationNumber[i] = registrationNumber;
                        //CarsCount++;
                        Console.WriteLine($"Car {registrationNumber} added");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("Registration list full");
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            for (int i = 0; i < _registrationNumber.Length; ++i)
            {
                if (_registrationNumber[i] == registrationNumber)
                {
                    _registrationNumber[i] = null;
                    //CarsCount--;
                    Console.WriteLine($"Car {registrationNumber} removed");
                    return;
                }
            }
            Console.WriteLine($"Cannot find car {registrationNumber}");
        }

        public override string ToString()
        {
            string registrationList = "";
            foreach (string registration in _registrationNumber)
            {
                if (registration != null)
                {
                    registrationList += " " + registration;
                }
            }
            return $"Person: \n FirstName: {FirstName}, LastName: {LastName}, Address: {Address} \n RegistrationList: {registrationList}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
