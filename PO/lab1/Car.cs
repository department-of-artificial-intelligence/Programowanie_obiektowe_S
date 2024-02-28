using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Car
    {
        private static int _carCount = 0;

        private string _brand, _model;
        private int _doorCount, _engineVolume;
        private double _avgConsump;

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int DoorCount { get => _doorCount; set => _doorCount = value; }
        public int EngineVolume { get => _engineVolume; set => _engineVolume = value; }
        public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }

        public Car() { }
        public Car(string brand, string model, int doorCount, int engineVolume, int avgConsump)
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineVolume = engineVolume;
            AvgConsump = avgConsump;
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Car count {_carCount}");
        }
        public double CalculateConsump(double pathInKm)
        {
            return pathInKm / 100 * AvgConsump;
        }
        public double CalculateCost(double pathInKm, double price)
        {
            return CalculateConsump(pathInKm) * price;
        }
        public override string ToString()
        {
            return "All info about a car";
        }
    }
}
