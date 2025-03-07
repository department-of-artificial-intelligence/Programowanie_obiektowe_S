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
        private static int _carCount = 0;

        public string Brand {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model {
            get { return _model; }
            set { _model = value; }
        }
        public int DoorCount {
            get { return _doorCount; }
            set { _doorCount = value; }
        }
        public float EngineVolume {
            get { return _engineVolume; }
            set { _engineVolume = value; }
        }
        public double AvgComsump {
            get { return _avgComsump; }
            set { _avgComsump = value; }
        }

        
    }

}
