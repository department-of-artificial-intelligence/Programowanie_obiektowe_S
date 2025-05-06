using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Garage
    {
        private Car[] _cars;
        private string _adress;
        private int _carsCount;
        private int _capacity;
        public int Capacity { get { return _capacity; } set { _capacity = value; _cars = new Car[value]; } }
        public string Address { get { return _adress; } set { _adress = value; } }
        public Garage()
        {
            _capacity = 0;
            _cars = new Car[Capacity];
            _adress = "unknown";
            _carsCount = 0;

        }
        public Garage(string adress, int capacity)
        {
            Capacity = capacity;
            _cars = new Car[Capacity];
            _adress = adress;
            _carsCount = 0;

        }
        public void CarIn(Car car)
        {
            if (_carsCount == Capacity)
            {
                Console.WriteLine("Garage is full");
                return;
            }
            else
            {
                _cars[_carsCount] = car;
                Console.WriteLine("Added car to the garage");
                _carsCount++;
            }
        }
        public Car CarOut()
        {
            if (_carsCount == 0)
            {

                Console.WriteLine("Garage is empty");
                return null!;
            }
            else
            {
                _carsCount--;
                Car temp = _cars[_carsCount];
                Console.WriteLine($"Deleted {temp} from the garage");
                _cars[_carsCount] = null!;
                return temp;

            }
        }
        public override string ToString()
        {   
            string temp = "";
            foreach (Car car in _cars)
            {
                if (car != null)
                { 
                    temp += car; 
                }

            }
            return $"Garage [{Address}]: {temp}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
