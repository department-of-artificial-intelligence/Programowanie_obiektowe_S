using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Garage
    {
        private Car[]? _cars;
        private string _address;
        private int _carsCount = 0;
        private int _capacity;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }
        public Garage()
        {
            _cars = null;
            _capacity = 0;
            _address = "nieznany";
        }
        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }
        public void CarIn(Car car)
        {
            if (_carsCount >= _capacity)
            {
                Console.WriteLine("Garage is full, can't add the car");
                return;
            }
            ++_carsCount;
            if (_cars == null)
                _cars = new Car[_carsCount];
            _cars[_carsCount-1] = car;
            Console.WriteLine($"Car {car.Brand} {car.Model} has been added to the garage");
        }

        public Car CarOut()
        {
            if (0 == _carsCount || _cars == null)
            {
                Console.WriteLine("Garage is empty");
                return null!;
            }
            --_carsCount;
            Car tmp = _cars[_carsCount ];
            _cars[_carsCount] = null;
            //Console.WriteLine($"Car {tmp.Brand} {tmp.Model} has been removed from the garage.");
            return tmp;
        }

        public override string ToString()
        {
            string res = $"Garage |  Address: {_address}, Capacity: {_capacity}, Cars count: {_carsCount}";
            res += '\n';
            if (0 == _carsCount || _cars == null) return res;
            foreach (var c in _cars)
            {
                res += c + "\n";
            }
            res += '\n';
            return res;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
