using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _carsCount = 0;
        private static int _maxCarCount = 3;
        private string[] _registrationNumbers = new string[3];

        public static int MaxCarCount
        {
            get { return _maxCarCount; }
            set { _maxCarCount = 3; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public int CarsCount
        {
            get { return _carsCount; }
            set
            {
                if(value > _maxCarCount)
                {
                    Console.WriteLine($"Nie można posiadać więcej niż {_maxCarCount} pojazdów.");
                    _carsCount = _maxCarCount;
                }
                else
                {
                    _carsCount = value;
                }
            }
        }

        public Person()
        {
            _firstName = "nieznane";
            _lastName = "nieznane";
            _address = "nieznany";
            _carsCount = 0;
        }

        public Person(string firstName, string lastName, string address)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            foreach (Car i in cars)
            {
                _registrationNumbers[_carsCount] = i.RegistrationNumber;
                _carsCount++;
                if (_carsCount == _maxCarCount)
                {
                    Console.WriteLine("Przekroczono limit posiadanych pojazdów. Więcej pojazdów nie zostanie przypisanych.");
                    break;
                }
            }
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if(_carsCount == _maxCarCount)
            {
                Console.WriteLine("Nie możesz posiadać więcej samochodów.");
            }
            else
            {
                _registrationNumbers[_carsCount] = registrationNumber;
                _carsCount++;
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            bool check = false;
            for(int i = 0; i < _carsCount; i++)
            {
                if(registrationNumber == _registrationNumbers[i])
                {
                    _registrationNumbers[i] = null;
                    check = true;
                }
                if (_registrationNumbers[i] == null)
                {
                    int j = i;
                    j++;
                    if(j != _carsCount)
                    {
                        _registrationNumbers[i] = _registrationNumbers[j];
                        _registrationNumbers[j] = null;
                    }
                }
            }
            if(check == false)
            {
                Console.WriteLine("Podano nieprawidłowy numer rejestracyjny.");
            }
            else
            {
                _carsCount--;
            }
        }

        public override string ToString()
        {
            string details = "RegistrationNumbers:\n";
            if(_registrationNumbers != null)
            {
                foreach (string i in _registrationNumbers)
                {
                    if (i != null)
                    {
                        details += i + ",\n";
                    }
                }
            }
            return details;
        }

        public void Details()
        {
            Console.WriteLine($"Person | FirstName: {_firstName}, LastName: {_lastName}, Address: {_address}, CarsCount: {_carsCount}, " + this.ToString());
        }
    }
}
