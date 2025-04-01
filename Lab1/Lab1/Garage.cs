using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Garage
    {
        private Car[] _cars;
        string _address;
        int _carsCount;
        int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }

        public string Address { get { return _address; } set { _address = value; } }

        public Garage()
        {
            _address = "nieznany";
            _carsCount = 0; 
            _capacity = 0;
            _cars = null;
        }

        public Garage(string address, int capacity )
        {
            _address = address; 
            _capacity = capacity;
            _cars = new Car[_capacity];
            _carsCount = 0;
            
        }


        public void CarIn(Car car)
        {
            if (_carsCount >= _capacity)
            {
                Console.WriteLine("Garaż jest pełny");
            }
            else
            {
                _cars[_carsCount] = car;
                _carsCount++;
                Console.WriteLine($"Samochód {car.Brand} {car.Model} wprowadzony do garażu.");
            }
        }

        public Car CarOut()
        {
            if ( _carsCount <= 0)
            {
                Console.WriteLine("Garaz jest pusty");
                return null;
            }
            else
            {
                _carsCount--;
                Car car = _cars[_carsCount];
                _cars[_carsCount] = null;
                Console.WriteLine($"Wyprowadzono samochod {car.Brand} {car.Model}");
                return car;
            }
        }

        public override string ToString()
        {
            string carsList = "";
            foreach (Car car in _cars)
            {
                if (car != null)
                {
                    carsList += car.ToString() + "\n";
                }
            }
            return $"Garage | Address: {_address}, Capacity: {_capacity}, CarsCount {_carsCount}\nCars:\n{carsList}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }


    }
}
