using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
   public class Car
    {
        private string _brand;
        private string _marka;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount = 0;

        public string Brand { get; set; }
        public string Marka { get; set; }
        public int DoorCount { get; set; }
        public float EngineVolume { get; set; }
        public double avgConsump { get; set; }

        public Car()
        {
            _brand = string.Empty;
            _marka = string.Empty;
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            _carCount++; 

        }

        public Car(string brand, string marka, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _marka = marka;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _carCount++;
            
        }

        public double CalculateConsump(double roadLength)
        {
            
            return (roadLength/100) * _avgConsump;
        }
        public double CalculateCost(double roadLength,double petrolCost) 
        {
            return CalculateConsump(roadLength) * petrolCost;        
        }

        public void Details()
        {
            Console.WriteLine()
        }
    }
}

