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
        private double _engineVolume;
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

        public double EngineVolume
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

        public Car() {
            _brand = null;
            _model = null;
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            ++_carCount;
        }

        public Car(string brand, string model, int doorCount, double engineVolume, double avgConsump)
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineVolume = engineVolume;
            AvgConsump = avgConsump;
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineVolume = engineVolume;
            AvgConsump = avgConsump;
        }
    }
}
