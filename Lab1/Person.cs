using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Person
    {
        private string[] _registrationNumbers;
        public const int MaxCarCount= 3;
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public int CarsCount {  get; set; }
        
        public Person()
        {
            FirstName = "nieznane1";
            LastName = "nieznane2";
            Address = "nieznany";
            CarsCount = 0;
            _registrationNumbers= new string[MaxCarCount];
        }
        public Person( string fn,string ln,string ad)
        {
            FirstName = fn;
            LastName = ln;
            Address = ad;
            CarsCount=0;
            _registrationNumbers = new string[MaxCarCount];
        }
        public Person(string fn, string ln, string ad, Car[] cars)
        {
            FirstName = fn;
            LastName = ln;
            Address = ad;
            _registrationNumbers = new string[MaxCarCount];
            CarsCount=cars.Length;
            if (cars.Length > MaxCarCount)
            {
                Console.WriteLine("za duzo samochodow !");
            }
            else
            {
                for (int i = 0; i < CarsCount; i++)
                {
                    _registrationNumbers[i] = cars[i].RegistrationNumber;
                }
            }
        
        }
        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if(CarsCount < MaxCarCount)
            {
                _registrationNumbers[CarsCount]= registrationNumber;
                CarsCount++;
            }
            else { Console.WriteLine("brak miejsca"); }

        }
        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            for (int i = 0; i < CarsCount; i++)
            {
                if (_registrationNumbers[i] == registrationNumber)
                {
                    _registrationNumbers[i] = null;
                    CarsCount--;
                }
                else { Console.WriteLine($"Nie znaleziono na pozycji: {i}  \n"); }
            }

            }

        public override string ToString()
        {
            string regis = "";
                for(int i=0; i < CarsCount; i++)
            {
                if (_registrationNumbers[i] != null)
                {
                    regis+= _registrationNumbers[i].ToString()+" ";
                }
            }
               
            return $"Imie : {FirstName} {LastName} Adres {Address} Liczba Samochodow {CarsCount} Registracje: {regis}";
        }


        public void Details()
        {
            Console.WriteLine(ToString() );
        }










    }
}
