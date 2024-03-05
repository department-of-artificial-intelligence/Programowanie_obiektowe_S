using System;
using System.Runtime.ExceptionServices;
using System.Text;
namespace klasy_tr
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private string _registrationNumber;
        private static int _carCount = 0;

        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }
        public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }

        public Car()
        {
            _brand = "unknown";
            _model = "unknown";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0.0;
            _carCount++;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            _engineVolume = engineVolume;
            AvgConsump = avgConsump;
            _carCount++;
        }

        public double CalculateConsump(double roadLength)
        {
            return (_avgConsump * roadLength) / 100.0;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            double consump = CalculateConsump(roadLength);
            return consump * petrolCost;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}," +
                   $"AverageConsumption: {_avgConsump}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"CarCount {_carCount}");
        }


    }

    public class Garage
    {
        private string _address;
        private int _capacity;
        private int _carsCount = 0;
        private Car[] _cars;

        public string Address { get { return _address; } set { _address = value; } }
        public int Capacity { get { return _capacity; } set { _capacity = value; _cars = new Car[value]; } }
        public int CarsCount { get { return _carsCount; } set { _carsCount = value; } }


        public Garage()
        {
            _address = "unknown";
            _capacity = 0;
            _cars = new Car[0];
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public void CarIn(Car c)
        {
            if (_carsCount < _capacity)
            {
                _cars[_carsCount] = new Car();
                _cars[_carsCount].Brand = c.Brand;
                _cars[_carsCount].Model = c.Model;
                _cars[_carsCount].DoorCount = c.DoorCount;
                _cars[_carsCount].EngineVolume = c.EngineVolume;
                _cars[_carsCount].AvgConsump = c.AvgConsump;
                _carsCount++;
            }
            else
            {
                Console.WriteLine("The garage is full.");
            }
        }

        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("The garage is empty.");
                return null;
            }
            else
            {
                Console.WriteLine(_cars[_carsCount - 1]);
                Car removedCar = _cars[CarsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                return removedCar;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Garage address: {_address}, capacity: {_capacity}");
            foreach (Car c in _cars)
            {
                if (c != null)
                {
                    result.AppendLine($"Brand: {c.Brand}, Model: {c.Model}, DoorCount: {c.DoorCount}, EngineVolume: {c.EngineVolume}, Average Consumption: {c.AvgConsump}");
                }
            }
            return result.ToString();
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }

    public class Person
    {
        private string[] _registrationNumbers;

        private int _maxCarCount;
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _carsCount;

        public int MaxCarCount { get { return _maxCarCount; } set { _maxCarCount = value; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public int CarsCount { get { return _carsCount; } set { _carsCount = value; } }
        public Person()
        {
            _maxCarCount = 3;
            _firstName = "";
            _lastName = "";
            _address = "";
            _carsCount++;
            _registrationNumbers = null;
        }

        public Person(string firstName, string lastName, string address)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;

        }

    }

    class Program
    {
        static void Main()
        {
            Car car1 = new();
            car1.Details();
            car1.Brand = "Fiat";
            car1.Model = "126p";
            car1.DoorCount = 2;
            car1.EngineVolume = 650;
            car1.AvgConsump = 6.0;
            car1.Details();
            Car car2 = new("Syrena", "105", 2, 0.8f, 7.6d);
            car2.Details();
            Console.WriteLine(car1);
            double routeConsumption = car2.CalculateConsump(500);
            Console.WriteLine($"Route consumption: {routeConsumption} l");
            double routeCost = car2.CalculateCost(500, 5);
            Console.WriteLine($"Route cost: {routeCost}");
            Car.DisplayCarCount();
            Console.WriteLine("\r\n=========================================\r\n");

            Garage garage1 = new();
            garage1.Address = "ul. Garażowa 1";
            garage1.Capacity = 1;
            Garage garage2 = new("ul. Garażowa 2", 2);
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
            Console.ReadLine();
        }
    }
}