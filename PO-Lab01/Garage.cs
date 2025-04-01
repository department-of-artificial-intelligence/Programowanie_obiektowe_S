using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_Lab01
{
    public class Garage
    {
        private Car[] _cars;
        private string _address;
        private int _carsCount;
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Garage() // konstruktor domyślny
        {
            _cars = null;
            _address = "nieznany";
            // _carsCount = 0;
            _capacity = 0;
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public void CarIn(Car car)
        {
            if (_carsCount >= _cars.Length)
            {
                Console.WriteLine("Garage full");
            }
            else
            {
                _cars[_carsCount] = car;
                Console.WriteLine($"Car added on position {_carsCount}");
                _carsCount++;
            }
        }

        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Garage empty");
                return null;
            }
            else
            {
                _carsCount--;
                Car removedCar = _cars[_carsCount];
                _cars[_carsCount] = null;
                Console.WriteLine($"Car deleted from position {_carsCount}");
                return removedCar;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var car in _cars)
            {
                result += car != null ? car.ToString() + "\n" : "brak\n";
            }
            return result;
        }

        public void Details()
        {
            Console.WriteLine($"Garage: \n Address: {_address}");
            if (_carsCount == 0)
            {
                Console.WriteLine(" No cars ");
            }
            foreach (var car in _cars)
            {
                if (car != null) Console.WriteLine(car.ToString());
            }
        }
    }
}
