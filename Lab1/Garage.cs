using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
        private string? _address;
        private int _capacity;
        private int _carsCount = 0;
        private Car[] _cars;

        public string Address
        {
            get { return _address; }
            set { _address = value;  }
        }

        public int Capacity
        {
            get { return _capacity; }
            set {
                _capacity = value;
                _cars = new Car[value];
            }
        }

        public Garage()
        {
            _address = null;
            _capacity = 0;
            _cars = null;
        }

        public Garage(string? address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public void CarIn(Car c)
        {
            if(_carsCount >= _capacity)
            {
                Console.WriteLine("Garage is full. Cannot add the car.");
            }
            else
            {
                _cars[_carsCount] = c;
                ++_carsCount;
                Console.WriteLine($"Car {c.Brand} {c.Model} has been added to the garage.");
            }
        }

        public Car CarOut()
        {
            if(_carsCount==0)
            {
                Console.WriteLine("The garage is empty.");
                return null!;
            }
            else
            {
                Car carToRemove = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                --_carsCount;
                Console.WriteLine($"Car {carToRemove.Brand} {carToRemove.Model} has been removed from the garage.");
                return carToRemove;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Garage Address: {_address ?? "Unknown"}");
            result.AppendLine($"Capacity: {_capacity}");
            result.AppendLine($"Cars count: {_carsCount}");

            if(_carsCount>0)
            {
                result.AppendLine("Cars in the garage:");
                foreach(Car car in _cars)
                {
                    if(car != null)
                    {
                        result.AppendLine(car.ToString());
                    }
                }
            }
            else
            {
                result.AppendLine("No cars in the garage.");
            }

            return result.ToString();
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
