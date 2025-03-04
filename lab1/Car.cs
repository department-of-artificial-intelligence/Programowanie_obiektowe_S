using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int Car_Count = 0;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public float EngineVolume { get; set; }
        public double AvgConsump { get; set; }

        public Car() {
            _brand = string.Empty;
            _model = string.Empty;
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            ++Car_Count;
        }
        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            ++Car_Count;
        }
        public double CalculateConsump(double roadLength) 
        { 
            return roadLength / 100 * _avgConsump;
        }
        public double CalculateCost(double roadLength, double petrolCost) 
        {
            return CalculateConsump(roadLength) * petrolCost;
        }
        public void Details()
        {
        }
    }
}
