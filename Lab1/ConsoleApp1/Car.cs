using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        private string? _brand;
        private string? _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private string? _registrationNumber;
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
        private static int _carCount = 0;
        public Car()
        {
            _brand = null;
            _model = null;
            _doorCount = 0;
            _engineVolume = 0.0f;
            _avgConsump = 0.0d;
            _registrationNumber = null;
            ++_carCount;
        }
        public Car(string? brand, string? model, int doorCount, float engineVolume, double avgConsump, string? registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            ++_carCount;
        }
        public double CalculateConsump(double roadLength)
        {
            double consump = (this.AvgConsump * roadLength) / 100.0;
            return consump;
        }
        public double CalculateCost(double roadLength, double petrolCost)
        {
            double cost = this.CalculateConsump(roadLength) * petrolCost;
            return cost;
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand ?? "Unknown"}, Model: {_model ?? "Unknown"}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump},  RegistrationNumber: {_registrationNumber ?? "Unknown"}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine($"There are {_carCount} cars.");
        }
    }
}