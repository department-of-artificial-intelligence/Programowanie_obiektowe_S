using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
		private string _address;
		private int _capacity;
		private int _carsCount;
		private Car[] _cars;

		public Garage()
		{
			_address = "";
			_capacity = 0;
			_carsCount = 0;
			_cars = null;
		}

		public Garage(string address, int capacity)
		{
			_address = address;
			_capacity = capacity;
			_cars = new Car[capacity];
			_carsCount = 0;
		}

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

		public void CarIn(Car car)
		{
			if (_carsCount < _capacity)
			{
				_cars[_carsCount] = car;
				_carsCount++;
				Console.WriteLine($"Car {car.Brand} {car.Model} added to the garage.");
			}
			else
			{
				Console.WriteLine("Garage is full. Cannot add more cars.");
			}
		}

		public Car CarOut()
		{
			if (_carsCount > 0)
			{
				Car lastCar = _cars[_carsCount - 1];
				_cars[_carsCount - 1] = null;
				_carsCount--;
				Console.WriteLine($"Car {lastCar.Brand} {lastCar.Model} removed from the garage.");
				return lastCar;
			}
			else
			{
				Console.WriteLine("No cars in the garage to remove.");
				return null;
			}
		}

		public override string ToString()
		{
			string garageInfo = $"Garage Address: {_address}, Capacity: {_capacity}, Cars Count: {_carsCount}\n";
			foreach (var car in _cars)
			{
				if (car != null)
				{
					garageInfo += car.ToString();
				}
			}
			return garageInfo;
		}

		public void Details()
		{
			Console.WriteLine(ToString());
		}
	}
}
