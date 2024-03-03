// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.DataAnnotations;
namespace Lab1.App
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
        public string RegistrationNumber { get { return _registrationNumber;} set { _registrationNumber = value; } }
        public Car()
        {
            _brand = "none";
            _model = "none";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0.0;
            _registrationNumber = "0000000";
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
            return (AvgConsump * roadLength) / 100;
        }
        public double CalculateCost(double roadLength, double petrolCost)
        {
            return CalculateConsump(roadLength) * petrolCost;
        }
        public override string ToString()
        {
            return $"Car | Brand:{_brand}, Model: {_model} NumOfDoors:{_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }
    }
    public class Garage
    {
        private Car[] _car;
        private string _address;
        private int _carCount;
        private int _capacity;
        public int Capacity{ get { return _capacity; } set { _capacity = value; _car = new Car[value]; } }
        public string Address{ get { return _address; } set { _address = value; } }
        public Garage()
        {
            _car = null;
            _address = "none";
            _capacity = 0;
            _carCount = 0; 
        }
        public Garage(string address, int capacity)
        {
            _car= new Car[capacity];
            _address = address;
            _capacity = capacity;
            _carCount = 0;
        }
        public void CarIn(Car car) 
        {
            if (_carCount+1 > Capacity)
            {
                Console.WriteLine("Garage is full");
            }
            else
            {
                _car[_carCount] = car;
                _carCount++;
            }
        }
        public Car CarOut()
        {
            if (_carCount>0 )
            {
                Car newCar = _car[_carCount - 1];
                _car[_carCount-1]=null;               
                _carCount--;
                return newCar;
            }
            Console.WriteLine("Garage is empty");
            return null;           
        }
        public override string ToString()
        {
            string otwet=$"Address: {Address}, {_carCount}, Capasity {Capacity}, \n";
            foreach (Car car in _car)
            {
                if (car != null)
                {
                    otwet += car.ToString() + '\n';
                }
            }
            return otwet;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
    public class Person
    {
        private static int _MaxCarCount = 3;
        private string[] _regestrationNummber;
        public static int MaxCarCount { get { return _MaxCarCount; } set { _MaxCarCount = value; } }
        public string Name { get; set ;}
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount { get;  set; }
        public Person()
        {
            _regestrationNummber = new string[MaxCarCount];
            Name = "none";
            LastName = "none";
            Address = "none";
        }
        public Person(string name, string lastName, string address)
        {
            _regestrationNummber = new string[MaxCarCount];
            Name = name;
            LastName = lastName;
            Address = address;
        }
        public Person(string name, string lastName, string address, Car[] car)
        {
            Name = name;
            LastName = lastName;
            Address = address;
            _regestrationNummber = new string[MaxCarCount];
            int i = 0;
            foreach (Car car2 in car) 
            {
                if (car2 != null)
                {
                    if (!(CarsCount == 3))
                    {
                        _regestrationNummber[i] = car2.RegistrationNumber;
                        CarsCount++;
                        i++;
                    }
                }
            }
        }
        public void AddCarRegistrationNumber(string regestrationNummber) 
        {
            if (CarsCount <= MaxCarCount)
            {
                _regestrationNummber[CarsCount]=regestrationNummber;
                CarsCount++; 
            }
        }
        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            if (CarsCount <= 0)
            {
                Console.WriteLine("No cars registered.");
                return;
            }
            for (int i = 0; i < CarsCount; i++)
            {
                if (_regestrationNummber[i] == registrationNumber)
                {
                    for (int j = i; j < CarsCount - 1; j++)
                    {
                        _regestrationNummber[j] = _regestrationNummber[j + 1];
                    }
                    CarsCount--;
                    return;
                }
            }
            Console.WriteLine("Car not found.");
        }
        public override string ToString()
        {
            string otwet = $"Address: {Address}, Name: {Name}, LastName {LastName}, \n";
            for (int i = 0; i < CarsCount;i++)
            {    
                otwet += _regestrationNummber[i] + ' ';
            }
            return otwet;
        }
        public void Details()
        {
            Console.WriteLine(this);
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
            Person person1 = new Person();
            person1.Name = "John";
            person1.LastName = "Doe";
            person1.Address = "123 Main St";

            Person person2 = new Person("Alice", "Smith", "456 Elm St");

            Car[] cars = { car1, car2 };
            Person person3 = new Person("Bob", "Johnson", "789 Oak St", cars);

            person1.Details();
            person2.Details();
            person3.Details();

            person1.AddCarRegistrationNumber("ABC123");
            person1.AddCarRegistrationNumber("XYZ456");
            person1.AddCarRegistrationNumber("DEF789");
            person1.Details();

            person1.RemoveCarRegistrationNumber("XYZ456");
            person1.Details();

        }
    }
}