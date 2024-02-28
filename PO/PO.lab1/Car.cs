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
        private static int _carCount = 0;
        private double _consump;
        private double _cost;
        private string _registrationNumber;

        public string Brand { get; set; }

        public string Model { get; set; }

        public int DoorCount { get;  set; }

        public float EngineVolume { get; set; }

        public double AvgConsump { get; set; }

        public string RegistrationNumber {  get; set; }

        public Car()
        {
            _brand = "nieznana";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            _carCount = _carCount++;
            _consump = 0;
            _cost = 0;
            _registrationNumber = "nieznany";
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
        {

            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;

        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumberOfDoors: {_doorCount}, EngineVolume: {_engineVolume}, AvarageConsump: {_avgConsump}, RegistrationNumber {_registrationNumber}";
        }

        public double CalculateConsump(double roadLength)
        {
            _consump = (_avgConsump * roadLength) / 100.0;
            return _consump;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            _cost = _consump * petrolCost;
            return _cost; 
        }

        public void Details()
        {
            this.ToString();
        }

        public void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }










    }
}
