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
        private double _avgConsump;
        private static int carCount;

        public double AvgConsump
        {
            get { return _avgConsump; }
            set { _avgConsump = value; }
        }
    }
}
