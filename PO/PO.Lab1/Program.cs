using System.Net;
using System.Reflection;
using static PO.Lab1.Program;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace PO.Lab1
{
    class Program
    {
        public class Car
        {

            private string _brand;
            private string _model;
            private string _registrationNumber;
            private int _doorCount;
            private float _engineVolume;
            private double _avgConsump;
            private static int _carCount;

            public string Brand
            {
                get { return _brand; }
                set { _brand = value; }
            }
            public string RegistrationNumber
            {
                get;set;
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
                Brand = "nieznany";
                Model = "nieznany";
                DoorCount = 0;
                EngineVolume = 0;
                AvgConsump = 0;
                _carCount++;
            }
            public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
            {
                Brand = brand;
                Model = model;
                DoorCount = doorCount;
                EngineVolume = engineVolume;
                AvgConsump = avgConsump;
                _carCount++;
            }
            public override string ToString()
            {
                return $"Brand: {_brand}, Model: {_model}, EngineVolume: {_engineVolume}, AvgConsump: {_avgConsump}, Door count {_doorCount}";
            }
            public double CalculateConsump(double roadLength)
            {
                return (AvgConsump * roadLength) / 100.0;
            }
            public double CalculateCost(double roadLength, double petrolCost)
            {
                return (CalculateConsump(AvgConsump) * roadLength);
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
            private Car[] _cars;
            private string _address;
            private int _carsCount;
            private int _capacity;

            public int Capacity
            {
                get { return _capacity; }
                set
                {
                    _capacity = value;
                    _cars = new Car[value];
                }
            }
            public string Address
            {
                get { return _address; }
                set { _address = value; }
            }
            public Garage()
            {
                _address = "nieznany";
                _carsCount = 0;
                _capacity = 0;
                _cars = new Car[_capacity];
            }
            public Garage(string address, int capacity)
            {
                _address = "address";
                _carsCount = 0;
                _capacity = capacity;
                _cars = new Car[_capacity];
            }
            public void CarIn(Car Car1)
            {
                if(_capacity >= (_carsCount + 1)) { 
                _cars[_carsCount] = Car1;
                _carsCount++;
                }
                else {
                    Console.WriteLine("Garage full");
                }
            }
            public Car CarOut()
            {
                if (_carsCount > 0)
                {
                    Car NewCar = new Car()
                    {
                        Brand = _cars[_carsCount-1].Brand,
                        Model = _cars[_carsCount-1].Model,
                        DoorCount = _cars[_carsCount - 1].DoorCount,
                        EngineVolume = _cars[_carsCount - 1].EngineVolume,
                        AvgConsump = _cars[_carsCount - 1].AvgConsump
                    };
                    _cars[_carsCount-1] = null;
                    _carsCount--;
                    return NewCar;
                }
                Console.WriteLine("Garage jest pusty");
                return null;
            }
            public override string ToString()
            {
                string result = $"Address: {_address}, CarsCount: {_carsCount}, Capacity: {_capacity}, Cars:" + '\n';
                foreach(Car CAR in _cars)
                {
                    if (CAR == null)
                        break;
                    result += CAR.ToString() + '\n';
                }
                return result;
            }
            public void Details()
            {
                Console.WriteLine(this.ToString());
            }
    }
        public class Person
        {
            private string[] _registrationNumbers;
            public static int MaxCarCount
            {
                get;
                set;
            }
            = 3;
            public string FirstName
            {
                get; set;
            }
            public string LastName
            {
                get; set;
            }
            public string Address
            {
                get; set;
            }
            public int CarsCount
            {
                get; set;
            }
            public Person()
            {
                _registrationNumbers = new string[MaxCarCount];
            }
            public Person(string firstName, string lastName, string address)
            {
                FirstName = firstName;
                LastName = lastName;
                Address = address;
                CarsCount = 0;
                _registrationNumbers = new string[MaxCarCount];
            }
            public Person(string firstName, string lastName, string address, Car[] CARS)
            {
                FirstName = firstName;
                LastName = lastName;
                Address = address;
                CarsCount = 0;
                _registrationNumbers = new string[CARS.Length];
                int i = 0;
                foreach (Car CAR in CARS)
                {
                    if (CAR == null)
                        break;
                    if (!(CarsCount==3)) { 
                    _registrationNumbers[i] = CAR.RegistrationNumber;
                    CarsCount+=1;
                    i++;
                    }
                }
            }
            public void AddCarRegistrationNumber(string registrationNumber)
            {
                if (CarsCount < 3) { 
                _registrationNumbers[CarsCount] = registrationNumber;
                CarsCount++;
                }
            }
            public void RemoveCarRegistrationNumber(string registrationNumber)
            {
                if (CarsCount <= 0)
                {
                    Console.WriteLine("No cars registered.");
                    return;
                }
                for (int i = 0; i < CarsCount; i++)
                {
                    if (_registrationNumbers[i] == registrationNumber)
                    {
                        for (int j = i; j < CarsCount - 1; j++)
                        {
                            _registrationNumbers[j] = _registrationNumbers[j + 1];
                        }
                        CarsCount--;
                        return;
                    }
                }
                Console.WriteLine("Car not found.");
            }
            public override string ToString()
            {
                string result = $"FirstName: {FirstName}, LastName: {LastName}, Address: {Address}, RegistrationNumbers:" + '\n';
                for(int i = 0; i<CarsCount; i++) 
                {
                    if (_registrationNumbers == null)
                        break;
                    result += _registrationNumbers[i] + '\n';
                }
                return result;
            }
            public void Details()
            {
                Console.WriteLine(this.ToString());
            }
        }

        public static void Main(string[] args)
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
            //Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d, "WE1234");
            Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d);
            car2.Details();
            Console.WriteLine(car1);
            double routeConsumption = car2.CalculateConsump(500);
            Console.WriteLine($"Route consumption: {routeConsumption} l");
            double routeCost = car2.CalculateCost(500, 5);
            Console.WriteLine($"Route cost: {routeCost}");
            Car.DisplayCarCount();
            Console.WriteLine("\r\n=========================================\r\n");

            Garage garage1 = new Garage();
            garage1.Address = "ul. Garażowa 1";
            garage1.Capacity = 1;
            Garage garage2 = new Garage("ul. Garażowa 2", 2);
            garage1.CarIn(car1);
            garage1.Details();
            garage1.CarIn(car2);
            garage2.CarIn(car2);
            var movedCar = garage1.CarOut();
            garage2.CarIn(movedCar);
            garage2.Details();
            garage1.Details();
            garage2.CarOut();
            garage2.Details();
            garage2.CarOut();
            garage2.CarOut();
            garage2.Details();
            garage1.Details();
            Console.WriteLine("\r\n=========================================\r\n");
            Person person1 = new Person();
            person1.FirstName = "John";
            person1.LastName = "Doe";
            person1.Address = "123 Main St";

            Person person2 = new Person("Alice", "Smith", "456 Elm St");

            Car[] cars = { car1, car2 };
            Person person3 = new Person("Bob", "Johnson", "789 Oak St", cars);

            person1.Details();
            person2.Details();
            person3.Details();

            person1.AddCarRegistrationNumber("ABC123");
            person1.AddCarRegistrationNumber("XYZ456");
            person1.AddCarRegistrationNumber("DEF789");
            person1.Details();

            person1.RemoveCarRegistrationNumber("XYZ456");
            person1.Details();
        }


    }
}


