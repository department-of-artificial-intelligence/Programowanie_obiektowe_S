using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        private static int _maxCarCount = 3;
        private string[] _registrationNumber;
        private string _lastName;
        private string _address;
        private int _carsCount = 0;

        public int MaxCarCount
        {
            get { return Person._maxCarCount; }
        }
        public string FirstName
        {
            get; set; //W momencie kompilacji kompilator utworzy pole
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
            _firstName = "nieznany";
            _lastName = "nieznany";
            _address = "nieznany";
            _carsCount = 0;
        }

        public Person(string FirstName, string LastName, string Address)
        {
            _firstName = FirstName;
            _lastName = LastName;
            _address = Address;
            _carsCount = 0;
        }

        public void AddCarRegistrationNumber(string RegistrationNumber)
        {
            if (_maxCarCount < _carsCount)
            {
                Console.WriteLine("Za dużo samochodów, można mieć maks 3");
                return;
            }
            _registrationNumber[_carsCount] = RegistrationNumber;
            _carsCount++;
        }

        public void RemoveCarRegistrationNumber(string RegistrationNumber)
        {
            for(int i = 0; i< _maxCarCount; i++)
            {
                if (_registrationNumber[i] == RegistrationNumber){
                    _registrationNumber[i] = null;
                    _carsCount--; //jak null to nadal istnieje, wiec nie jestem pewien czy ten carCount-- to poprawny
                }

            }
        }

        public override string ToString()
        {
            return $"Person | FirstName {_firstName}, RegistrationNumber {_registrationNumber}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }



}
