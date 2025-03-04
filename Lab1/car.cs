using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgComsump;
        private static int _carCount;

        public string Brand { get; set;}
        public string Model { get; set;}
        public int DoorCount { get; set;}
        public float EngineVolume { get; set;}
        public double AverageComsump { get; set; }
    }

}
