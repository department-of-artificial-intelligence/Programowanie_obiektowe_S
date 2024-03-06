using System;
using System.Numerics;
class Program
{
    class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount=0;

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

        public Car()
        {
            _brand = "nieznana";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0.0f;
            _avgConsump = 0.0;
            _carCount++;
        }

        public Car(string brand,string model,int doorCount,float engineCount,double avgConsump)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineCount;
            _avgConsump = avgConsump;
            _carCount++;
        }

        public double CalculateConsump(double roadLenght)
        {
            double consump=0;
            consump = (_avgConsump * roadLenght) / 100.0;
            return consump;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            double cost;
            cost = CalculateConsump(roadLength) * petrolCost;
            return cost;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors { _doorCount}, EngineVol: { _engineVolume}, AvgConsump: { _avgConsump}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine(_carCount);
        }
    class Garage
    {
            private Car[] _cars;
            private string _address;
            private int _carsCount=0;
            private int _capacity;

            public string Address { get => _address; set => _address = value; }
            public int CarsCount { get => _carsCount; set => _carsCount = value; }
            public int Capacity
            {
                get { return _capacity; }
                set 
                {
                    _capacity = value;
                    _cars = new Car[value];
                }
            }
            public Garage()
            {
                _cars = null;
                _address = "nienzany";
                _capacity = 0;  
            }
            public Garage(string address,int capacity)
            {
                _address = address;
                _capacity = capacity;
                _cars = new Car[_capacity];
            }

            public void CarIn(Car c1)
            {
                if (_carsCount >= _capacity)
                {
                    Console.WriteLine("Garaz zapelniony!");
                }
                else
                {
                    _cars[_carsCount] = c1;
                    _carsCount++;
                }
            }
        }

}

    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Details();
        car1.Brand = "Fiat";
        car1.Model = "126p";
        car1.DoorCount = 2;
        car1.EngineVolume = 650;
        car1.AvgConsump = 6.0;
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
