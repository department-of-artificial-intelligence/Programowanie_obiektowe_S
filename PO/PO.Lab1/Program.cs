using System.Runtime.InteropServices.Marshalling;

namespace Lab1.App
{
    public class Car
    {
        private string? _brand;
        private string? _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        static int carCount=0;
        private string? _registrationNumber;

        public Car()
        {
            _brand = "none";
            _model = "none";
            DoorCount = 0;
            EngineVolume = 0;
            AvgConsump = 0;
            _registrationNumber = "none";
            carCount += 1;
        }

        public Car(string brand, string model, int doorcount, float enginevolume, double avgconsump, string registrationnumber)
        { 
            _brand=brand;
            _model=model;
            DoorCount=doorcount;
            EngineVolume=enginevolume;
            AvgConsump=avgconsump;
            _registrationNumber = registrationnumber ;
            carCount += 1;
        }

        public string? Brand { get => _brand; set => _brand = value; }
        public string? Model { get => _model; set=> _model=value; }
        public string? RegistrationNumber { get=>_registrationNumber; set=> _registrationNumber = value; }
        public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }
        public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }

        public double CalculateConsump(double route)
        {
            return (_avgConsump * route) / 100;
        }

        public double CalculateCost(double route, double price)
        {
            return CalculateConsump(route) * price;
        }

        public override string ToString()
        {
            return $"Auto {Brand} {Model} {DoorCount}-drzwiowy z pojemnością silnika {EngineVolume} oraz spalaniem {AvgConsump} na 100km\n";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"Ilość aut w obiegu: {carCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Details();
            car1.Brand = "Fiat";
            car1.Model = "126p";
            car1.DoorCount = 2;
            car1.EngineVolume = 650;
            car1.AvgConsump = 6.0;
            car1.RegistrationNumber = "KR12345";
            car1.Details();
            Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d, "WE1234");
            car2.Details();
            Console.WriteLine(car1);
            double routeConsumption = car2.CalculateConsump(500);
            Console.WriteLine($"Route consumption: {routeConsumption} l");
            double routeCost = car2.CalculateCost(500, 5);
            Console.WriteLine($"Route cost: {routeCost}");
            Car.DisplayCarCount();
            Console.WriteLine("\r\n=========================================\r\n");
        }
    }
}


