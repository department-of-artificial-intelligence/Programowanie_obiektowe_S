using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Garage
    {
        private Car[] _cars;
        private string _address;
        private int _carsCount = 0;
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set { 
                _capacity = value;
                _cars = new Car[value];
            }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        
        public Garage()
        {
            _cars = null!;
            _address = "nieznany";
            _capacity = 0;
        }
        // raczej zgodnie z treścią. co prawda 4 warning-i ale działa.

        public Garage( string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[_capacity];
        }

        public void CarIn(Car car)
        {
            if(_carsCount >= _capacity)
            {
                Console.WriteLine("garage full");
            }
            else
            {
                _cars[_carsCount] = car;
                _carsCount++;
            }
        }

        public Car CarOut()
        {
            if(_carsCount == 0)
            {
                Console.WriteLine("garage empty");
                return null!;
            }
            else
            {
                _carsCount--;
                Car tmp = _cars[_carsCount];
                _cars[_carsCount] = null!;
                return tmp;
            }
        }

        public override string ToString()
        {
            string tmp = $"Garage | Address: {_address}, " +
                $"CarsCount: {_carsCount}, Capacity: {_capacity} \nCars:\n";
            foreach(Car car in _cars)
            {
                tmp = tmp + car;
            }
            return tmp;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}

