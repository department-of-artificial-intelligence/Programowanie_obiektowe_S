using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab1
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;

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
        private static int _carCount = 0;
        public Car()
        {
            _brand = "nieznana";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0f;
            _avgConsump = 0.0;
            _carCount++;
        }
        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _carCount++;

        }
        public double CalculateConsump(double roadLenght)
        {
            double consump = _avgConsump * roadLenght / 100.0;
            return consump;
        }
        public double CalculateCost(double roadLength, double petrolCost)
        {
            return CalculateConsump(roadLength) * petrolCost;
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump:{_avgConsump}";

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
}
