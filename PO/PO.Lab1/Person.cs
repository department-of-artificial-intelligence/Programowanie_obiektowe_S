using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
    public class Person
    {
        private string[]? _registrationNumbers;

        private int _maxCarCount;
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _carsCount;

        public int MaxCarCount { get { return _maxCarCount; } set { _maxCarCount = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public int CarsCount { get { return _carsCount; } set { _carsCount = value; } }
        public Person()
        {
            _maxCarCount = 3;
            _firstName = "";
            _lastName = "";
            _address = "";
            _carsCount = 0;
            _registrationNumbers = null;
        }

        public Person(string firstName, string lastName, string address)
        {
            _maxCarCount = 3;
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _carsCount = 0;
            _registrationNumbers = null;
        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _carsCount = cars.Length;
            for (int i = 0; i < cars.Length; i++)
            {
                _registrationNumbers[i] = cars[i].RegistrationNumber;
            }
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (CarsCount < MaxCarCount)
            {
                _registrationNumbers[CarsCount] = registrationNumber;
                CarsCount++;
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            for (int i = 0; i < _registrationNumbers.Length; i++)
            {
                if (_registrationNumbers[i] == registrationNumber)
                {
                    _registrationNumbers = null;
                    CarsCount--;
                }
            }
        }

        public override string ToString()
        {
            var str = "";
            str += string.Join<Person>('\n', _registrationNumbers);
            return str;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
