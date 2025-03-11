using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

        public string Address
        {
            get { return _address; } set { _address = value; }
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
            _cars = new Car[0];
        }

        public Garage(string address,int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[Capacity];
        }
        public void CarIn(Car car)
        {
            if (_carsCount < _capacity)
            {
                _cars[_carsCount] = car;
                _carsCount++;
            }
            else
            {
                Console.WriteLine("Garaz zapelniony");
            }
        }
        public Car? CarOut()
        {
            if (_carsCount > 0)
            {
                Car? car = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                return car;
            }
            else
            {
                Console.WriteLine("Garaz pusty");
                return null;
            }
        }

        public override string ToString()
        {
            string samochody="";
            foreach(var auto in _cars)
            {
                if (auto != null)
                {
                    samochody += auto.ToString();
                }
            }

            return $"Adres: {_address} Pojemnosc: {_capacity} \n " +
                $"Samochody:\n {samochody}";
                
        }
        public void Details()
        {
            Console.WriteLine(ToString());
        }







    }
}
