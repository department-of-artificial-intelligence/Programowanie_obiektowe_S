using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        string _brand;
        string _model;
        int _doorCount;
        float _engineVolume;
        double _avgConsump;
        string _registrationNumber;
        static int carCount = 0;

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
        public Car()
        {
            _brand = "Unknown";
            _model = "Unknown";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            _registrationNumber = "Unknown";
            carCount++;
        }
        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            carCount++;
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: { _doorCount}, EngineVol: { _engineVolume}, AvgConsump: { _avgConsump}";
        }
        public double CalculateConsump(double roadLength)
        {
            return _avgConsump * roadLength / 100;
        }
        public double CalculateCost(double roadLength, double petrolCost)
        {
            return _avgConsump * roadLength * petrolCost / 100;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        static public void DisplayCarCount()
        {
            Console.WriteLine($"Car count = {carCount}");
        }
    }
}
