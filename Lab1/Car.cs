using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        public string _brand;
        public string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount = 0;
        public string brand {get; set;}
        public string model { get; set;}
        public int doorCount { get; set;}
        public float engineVolume { get; set;}
        public double avgConsump 
        {
         get { return _avgConsump; }
         set { _avgConsump = value; }
        }

        Constructor()
        {
            brand = null;
            model = null;

        }


    }
}
