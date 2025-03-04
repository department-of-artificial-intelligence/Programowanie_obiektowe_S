using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private string _registrationNumber;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount;
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        { 
            get { return _model; }
            set {  _model = value; }
        }
        public int DoorCount
        { 
            get { return _doorCount;}
            set { _doorCount = value; }
        }
        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }
        public float EngineVolume
        {
            get { return _engineVolume;}
            set { _engineVolume = value; }
        }
        public double AvgConsump
        { 
            get { return _avgConsump; }
            set { _avgConsump = value; }
        }
        public Car() 
        {
            _brand = "Nieznany";
            _model = "Nieznany";
            _registrationNumber = "Nieznany";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0.0;
            _carCount++;
        }
        public Car(string Brand, string Model, int DoorCount, float EngineVolume, double AvgConsump, string RegistrationNumber)
        {
            _brand = Brand;
            _model = Model;
            _doorCount = DoorCount;
            _engineVolume = EngineVolume;
            _avgConsump = AvgConsump;
            _registrationNumber = RegistrationNumber;
            _carCount++;
        }
        public double consump { get; set; }
    public double CalculateConsump(double roadLength)
        {
            return consump = (_avgConsump * roadLength) / 100.0;
        }
    public double CalculateCost(double roadLength, double petrolCost)
        {
            return consump * petrolCost;
        }
    public override string ToString()
        {
        return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:{ _doorCount}, EngineVol: { _engineVolume}, AvgConsump:{ _avgConsump}, RegistrationNumber: { _registrationNumber}";
        }
    public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    public void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }
    }

    }
