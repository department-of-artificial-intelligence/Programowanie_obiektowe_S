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
        private string[]? _registrationNumbers = null;

        public static int MaxCarCount
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public int CarsCount
        {
            get;
            set;
        }

        public Person()
        {
            FirstName = "nieznane";
            LastName = "nieznane";
            Address = "nieznany";
            CarsCount = 0;
        }

        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CarsCount = 0;
        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            CarsCount = 0;
            if (cars != null)
            {
                if (cars.Length > 3)
                    _registrationNumbers = new string[3];
                else
                    _registrationNumbers = new string[cars.Length];
                int j = 0;
                foreach (Car i in cars)
                {
                    _registrationNumbers[j] = i.RegistrationNumber;
                    ++CarsCount;
                    ++MaxCarCount;
                    if (CarsCount == 3)
                    {
                        Console.WriteLine("Osiągnięto limit posiadanych pojazdów. Więcej pojazdów nie zostanie przypisanych.");
                        break;
                    }
                    ++j;
                }
            }
            else
                Console.WriteLine("Brak pojazdów w podanej tablicy.");
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (CarsCount >= 3)
            {
                Console.WriteLine("Nie możesz posiadać więcej samochodów.");
                if (CarsCount > 3)
                    CarsCount = 3;
            }
            else
            {
                ++CarsCount;
                ++MaxCarCount;
                if (_registrationNumbers == null)
                    _registrationNumbers = new string[CarsCount];
                else
                    _registrationNumbers = new string[CarsCount];
                int indexHelp = CarsCount;
                _registrationNumbers[--indexHelp] = registrationNumber;
            }
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            bool check = false;
            if (_registrationNumbers != null)
            {
                for (int i = 0; i < CarsCount; ++i)
                {
                    if (registrationNumber == _registrationNumbers[i])
                    {
                        _registrationNumbers[i] = null!;
                        check = true;
                    }
                }
            }
            if (check == false)
                Console.WriteLine("Podano nieprawidłowy numer rejestracyjny.");
            else
            {
                --CarsCount;
                --MaxCarCount;
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
            Console.WriteLine(this.ToString() + $"Person | FirstName: {FirstName}, LastName: {LastName}, Address: {Address}, CarsCount: {CarsCount}");
        }
    }
}
