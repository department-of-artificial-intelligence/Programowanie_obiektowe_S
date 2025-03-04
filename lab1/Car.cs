using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1 {
	public class Car {
		private static int _carCount = 0;

		private string _brand;
		private string _model;
		private int _doorCount;
		private float _engineVolume;
		private double _avgConsump;

		public string Brand {
			get => _brand;
			set => _brand = value;
		}

		public string Model {
			get => _model;
			set => _model = value;
		}

		public int DoorCount {
			get => _doorCount;
			set => _doorCount = value;
		}

		public float EngineVolume {
			get => _engineVolume;
			set => _engineVolume = value;
		}

		public double AvgConsump {
			get => _avgConsump;
			set => _avgConsump = value;
		}

		public Car() {
			this._brand = "nieznana";
			this._model = "nieznany";
			this._doorCount = 0;
			this._engineVolume = 0.0f;
			this._avgConsump = 0.0d;
		}

		public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump) {
			this._brand = brand;
			this._model = model;
			this._doorCount = doorCount;
			this._engineVolume = engineVolume;
			this._avgConsump = avgConsump;
		}

		public double CalculateConsump(double roadLength) {
			return (this._avgConsump * roadLength) / 100.0;
		}

		public double CalculateCost(double roadLength, double petrolCost) {
			return this.CalculateConsump(roadLength) * petrolCost;
		}

		public override string ToString() {
			return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:{_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: ";

		}

		public void Details() {
			Console.WriteLine(this);
		}

		public static void DisplayCarCount() {
			Console.WriteLine(Car._carCount);
		}
	}
}
