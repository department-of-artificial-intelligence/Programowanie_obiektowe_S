using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
        {
            private string _name;
            private string[] _carRegistrations;
            private int _ownedCarsCount;

            public Person(string name)
            {
                _name = name;
                _carRegistrations = new string[3];
                _ownedCarsCount = 0;
            }

            public void AddCarRegistrationNumber(string regNumber)
            {
                if (_ownedCarsCount < 3)
                {
                    _carRegistrations[_ownedCarsCount++] = regNumber;
                }
                else
                {
                    Console.WriteLine("Osoba nie może posiadać więcej niż 3 samochody!");
                }
            }

            public void RemoveCarRegistrationNumber(string regNumber)
            {
                for (int i = 0; i < _ownedCarsCount; i++)
                {
                    if (_carRegistrations[i] == regNumber)
                    {
                        _carRegistrations[i] = null;
                        _ownedCarsCount--;
                        break;
                    }
                }
            }

            public override string ToString()
            {
                string cars = "";
                foreach (var reg in _carRegistrations)
                {
                    if (reg != null) cars += reg + ", ";
                }
                return $"Person | Name: {_name}, Cars: [{cars.TrimEnd(',', ' ')}]";
            }

            public void Details() => Console.WriteLine(this);
        }
}
