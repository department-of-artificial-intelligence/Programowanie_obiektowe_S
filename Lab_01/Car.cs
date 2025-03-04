using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private string _registrationNumber'


        public string Brand
        {
            get { return _brand; }
            set { Brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { Model = value; }
        }

        public int DoorCount
        {
            get { return _doorCount; }
            set { DoorCount = 0; }
        }

        public float EngineVolume
        {
            get { return _engineVolume; }
            set { EngineVolume = 0; }
        }

        public double AvgConsump
        {
            get { return _avgConsump; }
            set { AvgConsump = 0; }
        }

        public string RegistrationNumber
        { 
            get { return _registrationNumber; }
            set { RegistrationNumber = value; }
        }


        public Car()
        {
            _brand = "nieznane";
            _model = "nieznane";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
        }


        public Car (string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
        }

        


    }
}