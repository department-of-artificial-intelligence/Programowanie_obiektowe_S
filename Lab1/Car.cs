using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        private static int _carCount;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public float EngineVolume { get; set; }
        public double avgConsump { get; set; }

        public Car()
        {
            _brand = "none";
            _model = "none";
            _doorCount = 0;
            _engineVolume = 0f;
            _avgConsump = 0f;
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

        public override string ToString()
        {
            return "todo :3";
        }
    }
}
