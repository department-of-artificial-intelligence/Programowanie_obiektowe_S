using System.Net.Sockets;

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
		if(_carsCount >= _capacity)
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
		if(_carsCount == 0)
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

public class Person
{
	private string _firstName;
	private string _lastName;
	private int _age;
	private string[] _carRegistrationNumbers;
	private int _carCount;

	public string FirstName { get => _firstName; set => _firstName = value; }
	public string LastName { get => _lastName; set => _lastName = value; }
	public int Age { get => _age; set => _age = value; }

	public Person(string firstName, string lastName, int age)
	{
		_firstName = firstName;
		_lastName = lastName;
		_age = age;
		_carRegistrationNumbers = new string[3]; 
		_carCount = 0;
	}

	public void AddCarRegistrationNumber(string registrationNumber)
	{
		if (_carCount < 3)
		{
			_carRegistrationNumbers[_carCount] = registrationNumber;
			_carCount++;
		}
		else
		{
			Console.WriteLine("Maximum number of cars for this person.");
		}
	}

	public void RemoveCarRegistrationNumber(string registrationNumber)
	{
		for (int i = 0; i < _carCount; i++)
		{
			if (_carRegistrationNumbers[i] == registrationNumber)
			{
				_carRegistrationNumbers[i] = null;
				_carCount--;
				return;
			}
		}
		Console.WriteLine($"Car with registration number {registrationNumber} not found.");
	}

	public override string ToString()
	{
		string carRegistrationNumbers = string.Join(", ", _carRegistrationNumbers);
		return $"Person: {_firstName} {_lastName}, Age: {_age}, Cars: {carRegistrationNumbers}";
	}

	public void Details()
	{
		Console.WriteLine(this.ToString());
	}
}

class Program
{
    static void Main(string[] args)
    {
		Car car1 = new Car();
		car1.Details();
		car1.Brand = "Fiat";
		car1.Model = "126p";
		car1.DoorCount = 2;
		car1.EngineVolume = 650;
		car1.AvgConsump = 6.0;
		car1.RegistrationNumber = "KR12345";
		car1.Details();
		Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d, "WE1234");
		car2.Details();
		Console.WriteLine(car1);
		double routeConsumption = car2.CalculateConsump(500);
		Console.WriteLine($"Route consumption: {routeConsumption} l");
		double routeCost = car2.CalculateCost(500, 5);
		Console.WriteLine($"Route cost: {routeCost}");
		Car.DisplayCarCount();
		Console.WriteLine("\r\n=========================================\r\n");

		Garage garage1 = new Garage();
		garage1.Address = "ul. Garażowa 1";
		garage1.Capacity = 1;
		Garage garage2 = new Garage("ul. Garażowa 2", 2);
		garage1.CarIn(car1);
		garage1.Details();
		garage1.CarIn(car2);
		garage2.CarIn(car2);
		var movedCar = garage1.CarOut();
		garage2.CarIn(movedCar);
		garage2.Details();
		garage1.Details();
		garage2.CarOut();
		garage2.Details();
		garage2.CarOut();
		garage2.CarOut();
		garage2.Details();
		garage1.Details();
		Console.WriteLine("\r\n=========================================\r\n");
	}
}
