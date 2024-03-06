// See https://aka.ms/new-console-template for more information
using System.Globalization;

namespace Lab1.App
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount;
        
        public Car() {
            _brand = "none";
            _model = "none";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            _carCount++;
        }    
        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _model = model; 
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
              
          
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }

        public float EngineVolume
        {
            get { return _engineVolume; }
            set { _engineVolume = value; }
        }

        public double AvgConsump
        {
            get { return _avgConsump; }
            set { _avgConsump = value; }
        }

        public double CalculateConsump( double roadLenght)
        {
            return  (avgConsump * roadLength) / 100.0;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:
 { _doorCount}, EngineVol: { _engineVolume}, AvgConsump:
            { _avgConsump}, RegistrationNumber: { _registrationNumber}
            ";
}

    }



}
