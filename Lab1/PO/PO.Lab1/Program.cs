
namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount;

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int DoorCount { get => _doorCount; set => _doorCount = value; }
        public float EngineVolume { get => _engineVolume; set => _engineVolume = value; }
        public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }
        public static int CarCount { get => _carCount; set => _carCount = value; }

        public double CalculateConsump(double roadLenght)
        {
            return (_avgConsump * roadLenght) / 100.0;
        }

        public double CalculateCost(double roadLenght, double petrolCost)
        {
            return CalculateConsump(roadLenght) * petrolCost;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"Car count: {_carCount}");
        }

        public Car()
        {
            _brand = "nieznana";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0f;
            _avgConsump = 0.0;
            _carCount++;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _carCount++;
        }
    }

    public class Garage
    {
        private Car[] _cars;
        private string _address;
        private int _carsCount;
        private int _capacity;

        public int Capacity
        {
            get => _capacity; set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }
        public string Address { get => _address; set => _address = value; }


        public Garage()
        {
            _cars = null;
            _address = "nieznany";
            _carsCount = 0;
            _capacity = 0;
        }

        public Garage( )
        { 
            
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
            //car1.RegistrationNumber = "KR12345";
            car1.Details();
            Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d);
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
