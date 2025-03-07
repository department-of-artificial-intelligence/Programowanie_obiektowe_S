using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
        private string _address;
        private int _carsCount = 0;
        private int _capacity;
        private Car[] _cars;

        public string Address 
        {
            get { return _address; }
            set { _address = value; } 
        }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value;
                  _cars = new Car[value]; }
        }

        public Garage()
        {
            _address = "nieznany";
            //_carsCount = 0;
            _capacity = 0;
            _cars = null;
        }
        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[_capacity];
        }

        public void CarIn(Car car)
        {
            if(_carsCount >= _capacity)
            {
                Console.WriteLine("The garage is full!");
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
                Console.WriteLine("The garage is empty!");
                return null;
            }
            else
            {
                _carsCount--;
                Car Temp = _cars[_carsCount];
                _cars[_carsCount] = null;
                return Temp;
            }
        }

        public override string ToString()
        {
            string temp = $"Garage | Address: {_address}, CarsCount : {_carsCount}, Capacity : {_capacity} \nCars:\n";
            foreach (Car car in _cars)
            {
                temp = temp + car + "\n";
            }
            return temp;
        }
        public void Details()
        {
            Console.WriteLine(this);
        }


    }
}
