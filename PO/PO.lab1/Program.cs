using System;
using System.Net;

namespace PO.lab1
{
    class Program
    {
        class Car
        {
            private string _brand;
            private string _model;
            private int _doorCount;
            private float _engineVolume;
            private double _avgConsump;
            private static int _carCount = 0;

            public string Brand { get { return _brand; } set { _brand = value; } }
            public string Model { get { return _model; } set { _model = value; } }
            public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }
            public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
            public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }
            
            public Car()
            {
                _brand = string.Empty;
                _model = string.Empty;
                _doorCount = 0;
                _engineVolume = 0;
                _avgConsump = 0;
                _carCount++;
            }
            public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
            {
                Brand = brand;
                Model = model;
                DoorCount = doorCount;
                EngineVolume = engineVolume;
                AvgConsump = avgConsump;
                _carCount++;
            }
            public override string ToString() // nadpisanie metody ToString z klasy bazowej object
            {
                return $"Car Brand: {_brand}, Model: {_model}, Door Count: {_doorCount}, Engine Volume: {EngineVolume}, Average Consumption: {_avgConsump}";
            }
            public double CalculateConsump(double roadLength)
            {
                return (AvgConsump * roadLength) / 100.0;
            }
            public double CalculateCost(double roadLength, double petrolCost)
            {
                return CalculateConsump(roadLength) * petrolCost;
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
            Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d); //"WE1234"
            car2.Details();
            Console.WriteLine(car1);
            double routeConsumption = car2.CalculateConsump(500);
            Console.WriteLine($"Route consumption: {routeConsumption} l");
            double routeCost = car2.CalculateCost(500, 5);
            Console.WriteLine($"Route cost: {routeCost}");
            Car.DisplayCarCount();
            Console.WriteLine("\r\n=========================================\r\n");
        }
    }
}