using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    internal class Car
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

        public string RegistrationNumber {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }


        public Car()
        {
            _brand = "nieznane";
            _model = "nieznane'";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0.0;
            _registrationNumber = "nieznane";

            _carCount++;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgComsump, string RegistrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgComsump;
            _registrationNumber = RegistrationNumber;

            _carCount++;
        }

        public double CalculateConsump(double roadLength) {
            double consump =0.0;
            consump = (_avgConsump * roadLength) / 100.0;
            return consump;
        }

        public double CalculateCost( double roadLength, double petrolCost)
        {
            double cost = 0.0;
            cost = CalculateConsump(roadLength) * petrolCost;
            return cost;
         }


        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:{ _doorCount}, EngineVol: { _engineVolume}, AvgConsump:{ _avgConsump}, RegistrationNumber: { _registrationNumber}";
        }





    }
}
