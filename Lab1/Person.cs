using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Person
    {
        //pola
        private string[] _registrationNumbers;
        private int _carsCount;

        //właściwości
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public int MaxCarCount { get; set; }
        public int CarsCount
        {
            get { return _carsCount; }
            set { _carsCount = value; }
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if(_carsCount < MaxCarCount)
            {
                for(int i=0; i<_registrationNumbers.Length; ++i)
                {
                    if (_registrationNumbers[i] == null)
                    {
                        _registrationNumbers[i] = registrationNumber;
                        ++_carsCount;
                        Console.WriteLine($"Car with registration number {registrationNumber} has been added to {FirstName} {LastName}.");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} cannot have more than {MaxCarCount} cars.");
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            for (int i = 0; i < _registrationNumbers.Length; ++i)
            {
                if (_registrationNumbers[i] == registrationNumber)
                {
                    _registrationNumbers[i] = null;
                    --_carsCount;
                    Console.WriteLine($"Car with registration number {registrationNumber} has been removed from {FirstName} {LastName}.");
                    return;
                }
            }

            Console.WriteLine($"Car with registration number {registrationNumber} was not found.");
        }

        public Person()
        {
            FirstName = null;
            LastName = null;
            Address = null;
            MaxCarCount = 3;
            _registrationNumbers = new string[MaxCarCount];
            _carsCount = 0;
        }
        
        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            MaxCarCount = 3;
            _registrationNumbers = new string[MaxCarCount];
            _carsCount = 0;
        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            MaxCarCount = 3;
            _registrationNumbers = new string[MaxCarCount];
            _carsCount = 0;

            foreach(Car car in cars)
            {
                AddCarRegistrationNumber(car.RegistrationNumber);
            }
        }

        public override string ToString()
        {
            StringBuilder carList = new StringBuilder();

            foreach(string regNum in _registrationNumbers)
            {
                if(regNum != null)
                {
                    carList.Append(regNum + ", ");
                }
            }

            if(carList.Length > 0)
            {
                carList.Length -= 2;
            }

            return $"Person \n Name: {FirstName} {LastName},\nAddress: {Address},\nCars: {carList}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
