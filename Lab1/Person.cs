using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private string _registrationNumber;
        private static int _maxCarCount;
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _carsCount;

        public static int MaxCarCount{
            get { return _maxCarCount; }
            set { _maxCarCount = value; }
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
            set { _carsCount = value; }
        }

        public Person()
        {
            _registrationNumber = "nieznany";
            _maxCarCount = 0;
            _firstName = "nieznane";
            _lastName = "nieznane";
            _address = "nieznany";
            _carsCount = 0;
        }

        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

    }
}
