using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Bll
{
    public class Garage
    {
        private string _address;
        private int _carsCount;
        private int _capacity;
        private Car[] _car;
        public int Capacity { get => _capacity; set { _capacity = value; _car = new Car[value]; } }
        public Garage()
        {
            _address = "";
            _carsCount = 0;
            _capacity = 0;
            _car = new Car[_capacity];
        }
        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _car = new Car[_capacity];
            _carsCount++;
        }
        public string Address { get => _address; set => _address = value; }
        public Car? CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("jest pusty");
                return null;
            }
            else
            {
                Car car = _car[_carsCount - 1];
                _car[_carsCount - 1] = null;
                _carsCount--;
                return car;
            }


        }
        public override string ToString()
        {
            return $"Address: {_address}, _capacity: {_capacity}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
            foreach (Car e in _car)
            {
                if (e != null)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
        public void CarIn(Car c)
        {
            if (_carsCount == _capacity)
            {
                Console.WriteLine("jest pełny");
            }
            else
            {
                _car[_carsCount] = c;
                _carsCount++;
            }
        }

    }
}