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
        private float _engineCount;
        private double _avgConsump;
        private string? _registrationNumber;
        private static int _carCount=0;


        //konstruktor domyslny
        public Car() 
        {
            _brand = null;
            _model = null;
            _doorCount = 0;
            _engineCount = 0;
            _avgConsump = 0.0;
            _registrationNumber = null;
            _carCount++;

        }
        //konstruktor parametryczny
        public Car(string brand, string model, int doorCount, float engineCount, double avgConsump, string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineCount = engineCount;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            _carCount++;
        }

        public double CalculateConsump(double roadLength)
        {
            return (this.AvgConsump * roadLength) / 100.0;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            return this.CalculateConsump(roadLength) * petrolCost;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineCount}, AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }

        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

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
        public float EngineCount
        {
            get { return _engineCount; }
            set { _engineCount = value; }
        }
        public double AvgConsump
        {
            get { return _avgConsump; }
            set { _avgConsump = value; }
        }
       
    }
   
}

