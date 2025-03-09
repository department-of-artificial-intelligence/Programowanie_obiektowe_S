using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
        private Car[] _cars;
        private string _address;
        private int _carsCount = 0;
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value;  }
        }

        public Garage()
        {
            _cars = null;
            _address = "nieznany";
            _capacity = 0;
        }

        public Garage(string address, int capacity)
        {
            Address = address;
            Capacity = capacity;
        }

        public void CarIn(Car car)
        {
            if(_carsCount == Capacity)
            {
                Console.WriteLine("Garaż jest zapełniony.");
            }
            else
            {
                _cars[_carsCount] = car;
                _carsCount++;
            }
        }

        public Car CarOut()
        {
            if(_carsCount == 0)
            {
                Console.WriteLine("Garaż jest pusty.");
                return null;
            }
            else
            {
                int lastCar = _carsCount;
                lastCar--;
                Car COut = _cars[lastCar];
                _cars[lastCar] = null;
                _carsCount--;
                return COut;
            }
        }

        public override string ToString()
        {
            string details = "Garage | Cars:\n";
            foreach (Car i in _cars)
            {
                if(i != null)
                {
                    details += i.ToString() + ",\n";
                }
            }
            details += $"Address: {_address}, CarsCount: {_carsCount}, Capacity: {_capacity}";
            return details;
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
