using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Garage
    {
        private string _address;
        private int _capacity;
        private int _carsCount=0;
        private Car[] _cars;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value;
                  _cars = new Car[_capacity];
                }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public Garage()
        {
            _address = "none";
            _capacity = 0;
            _cars = new Car[_capacity];
         }
        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars =new Car[capacity];
        }
        public void CarIn(Car car)
        {
            if (_carsCount >= _capacity)
            {
                Console.WriteLine("Garaz jest pelny!");
            }
            else
            {
                _cars[_carsCount] = car;
                _carsCount++;
                Console.WriteLine($"Dodano {car.Brand} {car.Model} do garazu.");
            }
        }
        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Garaz jest pusty!");
                return null!;
            }
            else
            {
                Car wyprowadzone = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                Console.WriteLine($"Wyprowadzono {wyprowadzone.Brand} {wyprowadzone.Model} z garazu");
                return wyprowadzone;
            }
        }
        public override string ToString()
        {
            string result = $"Garage | Address: {_address}, Capacity: {_capacity}, Cars Count: {_carsCount} \n";
            
            if(_carsCount > 0)
            {
                result += "Cars in the garage: ";
                foreach (Car car in _cars)
                {
                    result += car.ToString() + "\n";
                }
            }
            else
            {
                result += "There's no cars in the garage";
            }

                return result;
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
