using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium1
{
    public class Garage
    {
        private Car[] _cars;
        private string _address;
        private int _carsCount;
        private int _capacity;

        public string Address { get { return _address; } set { _address = value; } }

        public int Capacity { get { return _capacity; } set { _capacity = value; } }

        public Garage(string address = "none", int capacity = 5)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[_capacity];
            _carsCount = 0;
        }

        public void CarIn(Car car)
        {
            if(_carsCount < _capacity)
            {
                _cars[_carsCount] = car;
                _carsCount++;
                Console.WriteLine($"Samochod {car.Brand}, {car.Model} wjechal do garazu");
            }
            else
            {
                Console.WriteLine("Garaz jest pelny! ");
            }

        }

        public Car CarOut()
        {
            if(_carsCount > 0)
            {
                Car car = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                return car;
            }
            return null;
        }

        public override string ToString()
        {
            string res = $"Adres garazu {_address}, pojemnosc {_capacity}, auta w srodku {_carsCount}\n";
            foreach(Car car in _cars)
            {
                if(car != null)
                {
                    res += $"samochod - {car.Brand}, {car.Model}\n";
                }
            }
            return res;
        }
        public void Details()
        {
            Console.WriteLine(this);
        }


    }

   


}
