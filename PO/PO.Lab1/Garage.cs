using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
	public class Garage
	{
		private Car[] _cars;
		private string _address;
		private int _carsCount = 0;
		private int _capacity;

		public string Address { get => _address; set => _address = value; }
		public int Capacity
		{
			get => _capacity;
			set
			{
				_capacity = value;
				_cars = new Car[value];
			}
		}

		public Garage()
		{
			_cars = Array.Empty<Car>();
			_address = "";
			_capacity = 0;
		}
		public Garage(string address, int capacity)
		{
			_address = address;
			_capacity = capacity;
			_cars = new Car[capacity];
		}

		public void CarIn(Car car)
		{
			if (_carsCount >= _capacity)
			{
				Console.WriteLine("Garage is full.");
			}
			else
			{
				_cars[_carsCount] = car;
				_carsCount++;
			}
		}

		public Car? CarOut()
		{
			if (_carsCount == 0)
			{
				Console.WriteLine("Garage is empty");
				return null;
			}
			else
			{
				Car carToMoveOut = _cars[_carsCount - 1];
				_cars[_carsCount - 1] = null;
				_carsCount--;
				return carToMoveOut;
			}
		}
		public override string ToString()
		{
			string result = $"Garage Address: {_address}, Capacity: {_capacity}, Cars Count: {_carsCount}\n";
			foreach (Car car in _cars)
			{
				if (car != null)
					result += car.ToString() + "\n";
			}
			return result;
		}

		public void Details()
		{
			Console.WriteLine(this.ToString());
		}
	}
}
