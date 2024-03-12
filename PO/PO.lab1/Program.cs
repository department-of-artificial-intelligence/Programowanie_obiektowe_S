// See https://aka.ms/new-console-template for more information 
using System;
using System.Text;
using System.Xml.Serialization;
namespace lab1.App
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount;
        public Car()
        {
            _carCount ++;
            _avgConsump = 0;
            _brand = string.Empty;
            _model = string.Empty;
            _doorCount = 0;
            _engineVolume = 0;
        }
        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand=brand;
            _model=model;
            _doorCount=doorCount;
            _engineVolume=engineVolume;
            _avgConsump=avgConsump;
            _carCount++;
        }
        public double CalculateConsump(double trasa)
        {
            if (trasa > 0)
            {
                Console.WriteLine("Srednie spalanie na trasie: ");
                return (_avgConsump/100)*trasa;
            }
            else
            {
                Console.WriteLine("Trasa mniej lub rowna 0");
                return 0;
            }
        }
        public string Brand {
            get {  return _brand; }
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
        public float EngineVolume
        {
            get { return _engineVolume; }
            set { _engineVolume = value; }
        }
        public double AvgConsump
        {
            get { return _avgConsump; }
            set { _avgConsump = value; }
        }
        public double CalculateCost (double price, double trasa)
        {
            if (trasa > 0)
            {
                return this.CalculateConsump(trasa) * price;
            }
            else {
                Console.WriteLine("trasa mniej lub rowna 0.");
                return 0;
            }
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDooors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}";
            }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }
    };
    public class Garage
    {
        private Car[] _cars = null!;
        private string _address = null!;
        private int _carCount = 0;
        public int _capacity;
        public Garage()
        {
            _carCount = 0;
            _capacity = 0;
        }
        public Garage(string address, int capacity)
        {
            _address = address;
            _cars = new Car[capacity];
            _capacity = capacity;
        }
        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value;
                _cars = new Car[value]; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public void CarIn(Car car)
        {
            if (_carCount >= _capacity)
            {
                Console.WriteLine("Garag jest pelny \n");
            }
            else
            {
                _cars[_carCount] = car;
                _carCount++;
                Console.WriteLine("Auto jest dodane do garagu");
            }
        }
        public Car CarOut()
        {
            if (_carCount == 0)
            {
                Console.WriteLine("Garage is empty. No cars to remove.");
                return null!;
            }
            else
            {
                Car removedCar = _cars[_carCount - 1];
                _cars[_carCount - 1] = null!;
                _carCount--;
                Console.WriteLine("Car removed from the garage.");
                return removedCar;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Garage Address: {_address}");
            stringBuilder.AppendLine($"Capacity: {_capacity}");
            stringBuilder.AppendLine($"Number of Cars: {_carCount}");
            stringBuilder.AppendLine("Cars in the Garage:");
            foreach (Car car in _cars)
            {
                if (car != null)
                    stringBuilder.AppendLine(car.ToString());
            }
            return stringBuilder.ToString();
        }

        public void Details()
        {
            Console.WriteLine($"Garage Address: {_address}");
            Console.WriteLine($"Capacity: {_capacity}");
            Console.WriteLine($"Number of Cars: {_carCount}");
            Console.WriteLine("Cars Details:");
            foreach (Car car in _cars)
            {
                if (car != null)
                    car.Details();
            }
        }

    };

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
            //car1.RegistrationNumber = "KR12345";
            car1.Details();
            Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d);
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
}