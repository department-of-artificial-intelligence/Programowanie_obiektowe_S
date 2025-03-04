using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engingeVolume;
        private double _avgConsump;
        static private int carCount = 0;
        private string _registrationNumber;

        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int DoorCount {  get { return _doorCount; } set { _doorCount = value; } }
        public float EngineVolume { get { return _engingeVolume; } set { _engingeVolume = value; } }
        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }
        public string RegistrationNumber { get { return _registrationNumber; } set { _registrationNumber = value; } }
        public Car()
        {
            _brand = "nieznana";
            _model = "nieznany";
            _doorCount = 0;
            _engingeVolume= 0.0f;
            _avgConsump = 0.0f;
            _registrationNumber = "nieznany";
            carCount++;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engingeVolume = engineVolume;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            carCount++;
        }

        public double CalculateConsump(double roadLength)
        {
            return (_avgConsump * roadLength)/100.0;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            return CalculateConsump(roadLength) * petrolCost;
        }

        public override string ToString()
        {
            return $"Car |Brand: {_brand}, Model: {_model}, NumOfDoors{_doorCount}, EngineVol: {_engingeVolume}, AvgConsump: {AvgConsump}, RegistrationNumber:{_registrationNumber}";
        }

        public void Details()
        {
            System.Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            System.Console.WriteLine(carCount);
        }
    }
}
