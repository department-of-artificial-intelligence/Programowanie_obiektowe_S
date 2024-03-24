using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
    public class Garage
    {
        private string _address;
        private int _capacity;
        private int _carsCount = 0;
        private Car[] _cars;

        public string Address { get { return _address; } set { _address = value; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; _cars = new Car[value]; } }
        public int CarsCount { get { return _carsCount; } set { _carsCount = value; } }


        public Garage()
        {
            _address = "unknown";
            _capacity = 0;
            _cars = new Car[0];
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public void CarIn(Car c)
        {
            if (_carsCount < _capacity)
            {
                _cars[_carsCount] = new Car();
                _cars[_carsCount].Brand = c.Brand;
                _cars[_carsCount].Model = c.Model;
                _cars[_carsCount].DoorCount = c.DoorCount;
                _cars[_carsCount].EngineVolume = c.EngineVolume;
                _cars[_carsCount].AvgConsump = c.AvgConsump;
                _carsCount++;
            }
            else
            {
                Console.WriteLine("The garage is full.");
            }
        }

        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("The garage is empty.");
                return null;
            }
            else
            {
                Console.WriteLine(_cars[_carsCount - 1]);
                Car removedCar = _cars[CarsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                return removedCar;
            }
        }

        public override string ToString()
        {
            var str = $"Garage address: {_address}, capacity: {_capacity}";
            str += string.Join<Car>('\n', _cars);
            return str;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
