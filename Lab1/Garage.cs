using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Garage
        {
            private string _address;
            private int _capacity;
            private int _carsCount;
            private Car[] _cars;

            public string Address { get => _address; set => _address = value; }
            public int Capacity
            {
                get => _capacity;
                set
                {
                    _capacity = value;
                    _cars = new Car[value];
                }
            }

            public Garage()
            {
                _address = "nieznany";
                _capacity = 0;
                _carsCount = 0;
                _cars = null;
            }

            public Garage(string address, int capacity)
            {
                _address = address;
                _capacity = capacity;
                _cars = new Car[capacity];
            }

            public void CarIn(Car car)
            {
                if (_carsCount < _capacity)
                {
                    _cars[_carsCount++] = car;
                }
                else
                {
                    Console.WriteLine("Garaż jest pełny!");
                }
            }

            public Car CarOut()
            {
                if (_carsCount > 0)
                {
                    Car car = _cars[--_carsCount];
                    _cars[_carsCount] = null;
                    return car;
                }
                Console.WriteLine("Garaż jest pusty!");
                return null;
            }

            public override string ToString()
            {
                string carsInfo = "";
                foreach (var car in _cars)
                {
                    if (car != null) carsInfo += car.ToString() + "\n";
                }
                return $"Garage | Address: {_address}, Capacity: {_capacity}, CarsCount: {_carsCount}\n{carsInfo}";
            }

            public void Details() => Console.WriteLine(this);
        }
}
