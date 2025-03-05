using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount = 0;

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int DoorCount { get => _doorCount; set => _doorCount = value; }
        public float EngineVolume { get => _engineVolume; set => _engineVolume = value; }
        public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }

        public Car()
        {
            _brand = "nieznany";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            _carCount += 1;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _carCount += 1;
        }


    }
}
