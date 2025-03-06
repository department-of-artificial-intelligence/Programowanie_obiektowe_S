using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
        private string? _address;
        private int _capacity;
        private int _carsCount = 0;
        private Car[] _cars;

        public string Address
        {
            get { return _address; }
            set { _address = value;  }
        }

        public int Capacity
        {
            get { return _capacity; }
            set {
                _capacity = value;
                _cars = new Car[value];
            }
        }

        public Garage()
        {

        }
    }
}
