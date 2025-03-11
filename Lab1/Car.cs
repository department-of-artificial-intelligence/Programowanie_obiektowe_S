namespace Lab1
{
    public class Car
    {
		private string _brand;
		private string _model;
		private int _doorCount;
		private double _engineVolume;
		private string _registrationNumber;
		private double _avgConsump;
		private static int _carCount = 0;

		public Car()
		{
			_brand = "";
			_model = "";
			_doorCount = 0;
			_engineVolume = 0.0;
			_avgConsump = 0.0;
			_carCount++;
			_registrationNumber = "";
		}

		public Car(string brand, string model, int doorCount, double engineVolume, double avgConsump, string r)
		{
			_brand = brand;
			_model = model;
			_doorCount = doorCount;
			_engineVolume = engineVolume;
			_avgConsump = avgConsump;
			_carCount++;
			_registrationNumber = r;
		}

		public string Brand
		{
			get { return _brand; }
			set { _brand = value; }
		}

		public string Model
		{
			get { return _model; }
			set { _model = value; }
		}

		public int DoorCount
		{
			get { return _doorCount; }
			set { _doorCount = value; }
		}

		public double EngineVolume
		{
			get { return _engineVolume; }
			set { _engineVolume = value; }
		}

		public double AvgConsump
		{
			get { return _avgConsump; }
			set { _avgConsump = value; }
		}

		public string RegistrationNumber
		{
			get { return _registrationNumber; }
			set { _registrationNumber = value; }
		}

		public double CalculateConsump(double roadLength)
		{
			return (_avgConsump * roadLength) / 100.0;
		}

		public double CalculateCost(double roadLength, double petrolCost)
		{
			return CalculateConsump(roadLength) * petrolCost;
		}

		public override string ToString()
		{
			return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber:{_registrationNumber} \n";
		}

		public void Details()
		{
			Console.WriteLine(this.ToString());
		}

		public static void DisplayCarCount()
		{
			Console.WriteLine($"Total cars created: {_carCount}");
		}
	}
}
