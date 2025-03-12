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
            set { _capacity = value; _cars = new Car[value]; }
        }
        public Garage()
        {
            _address = "nieznany";
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
            if (_carsCount >= _capacity)
            {
                Console.WriteLine("pelno");
                return; //return?
            }
            _cars[_carsCount] = car;
            _carsCount++;
        }

        public Car CarOut()
        {
            if (_carsCount <= 0)
            {
                Console.WriteLine("pusto");
                return null; //return?
            }
            _carsCount--;
            Car tempCar = _cars[_carsCount];
            //_cars[_carsCount] = null; // ta linia wywoływała referencje do nulla w linii 70, tak się kończy zabawa pamięcią, zostaw to dla gc
            return tempCar;

        }

        public override string ToString()
        {
            string a = $"Garage | Address: {_address}, Capacity: {_capacity}, CarsCount: {_carsCount}";
            if (_carsCount>0) { 
                foreach (Car car in _cars)
                {
                    a += car.ToString();
                }
            }
            return a;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
