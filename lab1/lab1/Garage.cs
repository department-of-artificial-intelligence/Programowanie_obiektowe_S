using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_1
{
    public class Garage
    {
        private string _address;
        private int _capacity;
        private int _carsCount = 0;
        private Car[] _cars;

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
            _address = "nieznany";
            _capacity = 0;
            _cars = null;
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
                Console.WriteLine("Garaż zapełniony");
            }

            else
            {
                _cars[_carsCount] = car;
                _carsCount++;
                Console.WriteLine($"Samochód {car.Brand} dodany");
            }
        }

        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine($"Garaz jest pusty");
                return null!;
            }
            else
            {
                Car removedCar = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                Console.WriteLine($"Samochod {removedCar.Brand} zabrany z garażu");
                return removedCar;
            }
        }
        public override string ToString()
        {
            string carList = "Samochody w garażu: ";
            foreach (var car in _cars)
            {
                if (car != null)
                {
                    carList += "\n" + car.ToString();
                }
            }
            return $"Garaż | Adres: {_address}, Pojemność:{_capacity}, Liczba aut: {_carsCount} \n{carList}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
