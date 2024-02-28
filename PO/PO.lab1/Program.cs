// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Lab1.App
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount=0;
        public string brand { get { return _brand; } set { _brand = value; } }
        public string model { get { return _model; } set { _model = value; } }
        public int doorCount { get { return _doorCount; } set { _doorCount = value; } }
        public float engineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
        public double avgConsump { get { return _avgConsump; } set { _avgConsump = value; } }
        Car()
        {
            _brand = "nieznany";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0.0;
            _carCount++;
        }
        Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _carCount++;
        }
        public double calculateConsump(double roadLength) 
        {
            return (avgConsump * roadLength)/100;  
        }
        public double calculateCost(double roadLength, double petrolCost)
        {
            return calculateConsump(roadLength) * petrolCost;
        }
    }
}