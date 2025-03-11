using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
        private string _addres;
        private int _capacity;
        private int _carCount = 0;
        private Car[] _cars;

        public Garage()
        {
            _addres = "brak";
            _capacity = 0;
            //_carCount = 0;
            _cars = null;
        }

        public Garage(string addres, int capacity)
        {
            _addres = addres;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public string Address
        {
            get { return _addres; }
            set { _addres = value; }
        }

        public int Capacity
        {
            get { return _capacity;  }
            set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }

        public void CarIn(Car car)
        {
            if(_carCount >= _capacity)
            {
                Console.Write("Garage is full!!\n");
            }
            else
            {
                _cars[_carCount] = car;
                _carCount++;
            }
        }

        public Car CarOut()
        {
            if(_carCount == 0)
            {
                Console.WriteLine("Garage is empty!!\n");
                return null;
            }
            else
            {
                _carCount--;
                Car Temp = _cars[_carCount];
                _cars[_carCount] = null;
                return Temp;
            }
        }

        public override string ToString()
        {
            string temp = $"Garage | Addres: {_addres}, CarCount: {_carCount}, Capacity: {_capacity} \nCars:\n";
            foreach(Car car in _cars)
            {
                temp += car + "\n";
            }
            return temp;
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
