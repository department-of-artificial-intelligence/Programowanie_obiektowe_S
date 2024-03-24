using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab01
{
    public class Garage
    {
        private Car[]? _cars;
        private string _address = null!;
        private int _carsCount = 0;
        private int _capacity;

        public int Capacity 
        { 
            get => _capacity;
            set 
            { 
                _capacity = value;
                _cars = new Car[Capacity];
            }
        }
        public string Address { get { return _address; } set { _address = value; } }
        public Garage()
        {
            _address = "Brak adresu";
            _capacity = 0;
            _cars = null;
        }
        public Garage(string address, int capacity)
        {
            _address = address;
            Capacity = capacity;
            _cars = new Car[Capacity];
        }
        public void CarIn(Car car)
        {
            if (_carsCount < _capacity)
            {
                _carsCount++;
                _cars[_carsCount - 1] = car;
            }
            else
                Console.WriteLine("Garaż jest zapełniony");
        }
        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Garaż jest pusty");
                return null;
            }
            else
            {
                Car a = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                return a;
            }
        }
        public override string ToString()
        {
            string a;
            a = $"Garaż -> Address: {_address}, Capacity: {_capacity}, ";
            a += $"NumOfCars:{_carsCount}, ";

            if (_cars != null)
            {
                foreach (Car i in _cars)
                {
                    if (i != null)
                    {
                        a += i.ToString();
                    }
                }
            }
            return a;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
