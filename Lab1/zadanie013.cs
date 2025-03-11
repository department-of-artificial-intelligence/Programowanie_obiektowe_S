using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie013
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
        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public Car() // konstruktor domyślny
        {
            _brand = "nieznany";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0.0f;
            _avgConsump = 0.0;
            _registrationNumber = "nieznany";
            _carCount++;
        }

        public Car(string brand,string model,int doorCount,float engineVolume,double avgConsump,string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            _carCount++;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
        }

        public double CalculateConsump(double roadLength) => (_avgConsump * roadLength) / 100.0; 
        public double CalculateCost(double roadLength,double petrolCost) => CalculateConsump(roadLength) * petrolCost;
        public void Details() => Console.WriteLine(this);
        public static void DisplayCarCount() => Console.WriteLine($"Number of cars created: {_carCount}");
    }

    public class Garage
    {
        private Car[] _cars;
        private string _address;
        private int _carsCount;
        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set 
            { 
                _capacity = value;
                _cars = new Car[value];
            }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public Garage() // konstruktor domyślny
        {
            _cars = null;
            _address = "nieznany";
            // _carsCount = 0;
            _capacity = 0;
        }

        public Garage(string address,int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public void CarIn(Car car)
        {
            if (_carsCount >= _cars.Length)
            {
                Console.WriteLine("Garaż jest pełny. Nie można dodać nowego samochodu.");
            }
            else
            {
                _cars[_carsCount] = car;
                Console.WriteLine($"Samochód dodany na pozycję {_carsCount}.");
                _carsCount++;
            }
        }

        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Garaż jest pusty. Brak samochodów do wyprowadzenia.");
                return null;
            }
            else
            {
                _carsCount--;
                Car removedCar = _cars[_carsCount];
                _cars[_carsCount] = null;
                Console.WriteLine($"Samochód z pozycji {_carsCount} został usunięty.");
                return removedCar;
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var car in _cars)
            {
                result += car != null ? car.ToString() + "\n" : "brak\n";
            }
            return result;
        }

        public void Details() // => Console.WriteLine(this);
        {
            Console.WriteLine("Informacje o samochodach w garażu:");
            foreach (var car in _cars)
            {
                if (car != null) Console.WriteLine(car.ToString());
            }
        }
    }

    class Program
    {
        static void Main()
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
}