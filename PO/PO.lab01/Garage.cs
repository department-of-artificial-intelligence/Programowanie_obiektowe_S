using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab01
{
    public class Garage
    {
        private string _address = null!;
        private int _capacity;
        private int _carsCount = 0;
        private Car[]? _cars;

        public string Address { get => _address; set => _address = value; }

        public int Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }

        public Garage()
        {
            _address = "Nieznany";
            _capacity = 0;
            _cars = null;
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public void CarIn(Car a)
        {
            if (_carsCount > 0)
            {
                if (_carsCount < _capacity)
                {
                    _cars[_carsCount - 1] = a;
                    _carsCount++;
                }
                else
                {
                    Console.WriteLine("Przekroczona pojemność garażu");
                }
            }
        }

        public Car CarOut()
        {
            Car a;
            if (_carsCount == 0)
            {
                Console.WriteLine("Garaż jest pusty");
                a = new Car();
                return a;
            }
            else
            {
                a = _cars[_carsCount - 1];
                _carsCount--;
                return a;
            }
        }

        public override string ToString()
        {
            string a;
            a = $"Garage | Address: {_address}, Capacity: {_capacity}, ";
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

        /*
               public override string ToString()
        {
            var str = $"Garage address: {_address}, capacity: {_capacity}";
            //str += string.Join('\n', _cars.ToList());
            str += string.Join<Car>('\n', _cars);
            return str;

            //StringBuilder result = new StringBuilder();
            //result.AppendLine($"Garage address: {_address}, capacity: {_capacity}");
            //foreach (Car c in _cars)
            //{
            //    if (c != null)
            //    {
            //        result.AppendLine($"Brand: {c.Brand}, Model: {c.Model}, DoorCount: {c.DoorCount}, EngineVolume: {c.EngineVolume}, Average Consumption: {c.AvgConsump}");
            //    }
            //}
            //return result.ToString();
        }
         */

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
