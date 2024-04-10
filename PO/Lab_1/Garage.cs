using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Przygotowanie
{
    internal class Garage
    {

        private Car[] _cars;
        private string _address;
        private int _carsCount;
        private int _capacity;

        public int Capacity { get { return _capacity; } set { _capacity = value; _cars = new Car[value]; } }
        public string Address { get { return _address; } set { _address = value; } }

        public Garage() {

            _address = "none";
            _capacity = 0;
            _carsCount = 0;
            _cars = new Car[0];


        }

        public Garage(string address, int capacity) {

            _address = address;
            _capacity = capacity;


        }

        public void CarIn(Car car) {

            if (_carsCount >= _capacity)
            {

                Console.WriteLine($"Garage is full.");

            }
            else
            {
                _cars[_carsCount] = car;
                _carsCount++;
                Console.WriteLine($"Car added to the garage.");
            }
        
        }

        public Car CarOut()
        {

            if (_carsCount == 0)
            {

                Console.WriteLine($"Garage is empty.");
                return null;

            }

            else {

                Car carToOut = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;

                Console.WriteLine($"Car deleted from garage.");
                return carToOut;
            }


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Garage Address {_address}");
            sb.AppendLine($"Garage Capacity {_capacity}");

            foreach ( var car in _cars )
            {

                sb.AppendLine(car.ToString());
            }

            return sb.ToString();

        }

        public void Details() {

            Console.WriteLine(ToString());

        }



    }
}
