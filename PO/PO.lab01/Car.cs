using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab01
{
    public class Car
    {
        private string _brand = null!; //nie może być nullem
        private string _model = null!; // null? -> może być nullem
        private int _doorCount;
        private double _engineVolume;
        private double _avgConsump;

        public static int _carCount = 0;

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int DoorCount { get => _doorCount; set => _doorCount = value; }
        public double EngineVolume { get => _engineVolume; set => _engineVolume = value; }
        public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }

        public Car()
        {
            Brand = "Nieznana";
            Model = "Nieznany";
            DoorCount = 0;
            EngineVolume = 0.0;
            AvgConsump = 0.0;
            _carCount++;
        }

        public Car(string a, string b, int c, double d, double e)
        {
            Brand = a;
            Model = b;
            DoorCount = 3;
            EngineVolume = d;
            AvgConsump = e;
            _carCount++;
        }



        public double Consump(double roadLength)
        {
            return (_avgConsump * roadLength) / 100.0;
        }

        public double Cost(double roadLength, double petrolCost)
        {
            double consum = Consump(roadLength);
            return consum * petrolCost;

        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:{_doorCount}, " +
                $"EngineVol: {_engineVolume}, _AvgConsump: {_avgConsump}, ";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }
    }
}
