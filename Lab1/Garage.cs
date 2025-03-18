using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
        private Car[]? _cars;
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
            set { _address = value; }
        }

        public Garage()
        {
            _cars = null;
            _address = "nieznany";
            _capacity = 0;
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            Capacity = capacity;
        }

        public void CarIn(Car car)
        {
            if(_carsCount == Capacity)
                Console.WriteLine("Garaż jest zapełniony.");
            else
            {
                ++_carsCount;
                if (_cars == null)
                    _cars = new Car[_carsCount];
                int indexHelp = _carsCount;
                _cars[--indexHelp] = car;
            }
        }

        public Car CarOut()
        {
            if(_carsCount == 0)
            {
                Console.WriteLine("Garaż jest pusty.");
                return new Car();
            }
            else
            {
                --_carsCount;
                Car COut = new Car();
                if (_cars != null)
                {
                    COut = _cars[_carsCount];
                    _cars[_carsCount] = null!;
                }
                return COut;
            }
        }

        public override string ToString()
        {
            string details = "Garage | Cars:\n";
            if(_cars != null)
            {
                foreach (Car i in _cars)
                {
                    if (i != null)
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
