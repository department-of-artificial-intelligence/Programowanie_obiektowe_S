using System;
using System.Collections.Specialized;
using System.Net.Sockets;
using System.Runtime.Versioning;
using System.Threading.Tasks.Dataflow;

namespace lab1.App
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

    public class Garage
    {
        private string _address = null!;
        private int _capacity;
        private int _carsCount = 0;
        private Car[]? _cars;

        public string Address { get => _address; set => _address = value; }

        public int Capacity
        {
            get
            { 
                return _capacity;
            }

            set 
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }

        public Garage()
        {
            _address = "Nieznany";
            _capacity = 0;
            _cars = null;
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];
        }

        public void CarIn(Car a)
        {
            if (_carsCount < _capacity)
            {
                _cars[_carsCount] = a;
                _carsCount++;
            }
            else
            {
                Console.WriteLine("Przekroczona pojemność garażu");
            }
        }

       /* public Car CarOut()
        {
            if(_carsCount == 0)
                Console.WriteLine("Garaż jest pusty");
            
        }
       */
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
            double routeConsumption = car2.Consump(500);
            Console.WriteLine($"Route consumption: {routeConsumption} l");
            double routeCost = car2.Cost(500, 5);
            Console.WriteLine($"Route cost: {routeCost}");
            Car.DisplayCarCount();
            Console.WriteLine("\r\n=========================================\r\n");
        }
    }
}