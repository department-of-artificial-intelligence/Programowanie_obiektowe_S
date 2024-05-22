using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Bll
{
    public class Car
    {
        private string _Brand;
        private string _Model;
        private int _DoorCount;
        private float _EngineVolume;
        private double _AvgConsump; 
        private string _RegistrationNumber; 

        private static int _carCount=0;
        public string Brand { get => _Brand; set => _Brand = value; }
        public string Model { get => _Model; set => _Model = value; }
        public int DoorCount { get => _DoorCount; set => _DoorCount = value; }
        public float EngineVolume { get => _EngineVolume; set => _EngineVolume = value; }
        public double AvgConsump { get => _AvgConsump; set => _AvgConsump = value; }
        public string RegistrationNumber { get => _RegistrationNumber; set => _RegistrationNumber = value; }


        public Car() {
            _Brand = "";
            _Model = "";
            _DoorCount = 0;
            _EngineVolume = 0.0f;
            _AvgConsump = 0.0;
            _RegistrationNumber = "";
            _carCount++;
        }
        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineVolume = engineVolume;
            AvgConsump = avgConsump;
            RegistrationNumber = registrationNumber;
            _carCount++;
        }
        public double CalculateConsump(double roadLength) {
            return roadLength * AvgConsump / 100;
        }
        public void Details()
        {
            Console.WriteLine($"Marka: {this.Brand}");
            Console.WriteLine($"Model: {this.Model}");
            Console.WriteLine($"Liczba drzwi: {this.DoorCount}");
            Console.WriteLine($"Pojemność silnika: {this.EngineVolume} cm³");
            Console.WriteLine($"Średnie spalanie: {this.AvgConsump} l/100km");
            Console.WriteLine($"Numer rejestracyjny: {this.RegistrationNumber}");
            Console.WriteLine();
        }

        public double CalculateCost(double distance, double fuelPrice)
        {
            return CalculateConsump(distance) * fuelPrice;
        }
        public override string ToString()
        {
            return $"Brand: {Brand}, Model: {Model}, Doors: {DoorCount}, Engine Volume: {EngineVolume}, Average Consumption: {AvgConsump}, Registration Number: {RegistrationNumber}";
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Liczba utworzonych samochodów: {_carCount}");
        }
        public void IncrementCarCount()
        {
            _carCount++;
        }
    }
}
