using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
	public class Car
	{
		private double _avgConsump;
		private string _brand;
		private string _model;
		private int _doorCount;
		private float _engineVolume;
		public string _registrationNumber;
		private static int _carCount = 0;

		public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }
		public string Brand { get => _brand; set => _brand = value; }
		public string RegistrationNumber { get => _registrationNumber; set => _registrationNumber = value; }
		public string Model { get => _model; set => _model = value; }
		public int DoorCount { get => _doorCount; set => _doorCount = value; }
		public float EngineVolume { get => _engineVolume; set => _engineVolume = value; }
		public Car()
		{
			_avgConsump = 0.0;
			_brand = "";
			_model = "";
			_registrationNumber = "";
			_doorCount = 0;
			_engineVolume = 0;
			_carCount++;
		}
		public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
		{
			_brand = brand;
			_model = model;
			_doorCount = doorCount;
			_engineVolume = engineVolume;
			_avgConsump = avgConsump;
			_registrationNumber = registrationNumber;
			_carCount++;
		}

		public double CalculateConsump(double roadLength)
		{
			return (_avgConsump * roadLength) / 100.0;
		}

		public double CalculateCost(double roadLength, double petrolCost)
		{
			return petrolCost * this.CalculateConsump(roadLength);
		}
		public override string ToString()
		{
			return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}" +
				$", EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
		}
		public void Details()
		{
			Console.WriteLine(this.ToString());
		}
		public static void DisplayCarCount()
		{
			Console.WriteLine($"CarCount: {_carCount}");
		}
	}
}
