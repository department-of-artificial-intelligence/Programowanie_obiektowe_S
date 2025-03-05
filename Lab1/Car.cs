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
    }
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }

    public string Model
    {
        get { retrun _model; }
        set { _model = value; } 
    }

    public int DoorCount
    {
        get { return _doorCount; }
        set { _doorCount}
    }



}
