using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount = 0;


        public string Brand { get { return _brand; } set { _brand = value; } }

        public string Model { get { return _model; } set { _model = value; } }

        public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }

        public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }

        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }

        public Car(string brand = "none", string model = "none", int doorCount = -1, float engineVolume = -1, double avgConsump = -1)
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
            return $" brand = {_brand}, model = {_model}, door count = {_doorCount}, engine volume = {_engineVolume}, avg consump = {_avgConsump} ";

        }

        public double CalculateConsump(double roadLength)
        {
            return (_avgConsump * roadLength) / 100.0;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            double consump = CalculateConsump(roadLength);
            return consump * petrolCost;
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Liczba utworzonych samochodow: {_carCount}");
        }

    }
}
