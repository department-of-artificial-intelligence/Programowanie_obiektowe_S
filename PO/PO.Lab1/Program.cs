using System;
using System.Net;
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
        private string _registrationNumber;

        public Car()
        {
            _carCount = 0;
            _model = "0";
            _doorCount = 0;
            _engineVolume = 0;
            _engineVolume = 0;
            _avgConsump = 0;
            _registrationNumber = "0";
            _carCount++;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineVolume;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            _carCount++;

        }

        public Car(Car car) // konstruktor kopiujący
        {
            _brand = car.Brand;
            _model = car.Model;
            _doorCount = car.DoorCount;
            _engineVolume = car.EngineVolume;
            _avgConsump = car.AvgConsump;
            _registrationNumber = car.RegistrationNumber;
            _carCount++;
        }



        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }
        public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }

        public string RegistrationNumber { get { return _registrationNumber; } set { _registrationNumber = value; } }
        public double CalculateConsump(double roadLength)
        {
            return (AvgConsump * roadLength) / 100.0;
        }
        public double CalculateCost(double roadLength, double petrolCost)
        {
            return CalculateConsump(roadLength) * petrolCost;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:{_doorCount}, EngineVol: {_engineVolume}, AvgConsump:{_avgConsump},RegistrationNumber: {_registrationNumber}";
        }

        public void Details()
        {
            Console.WriteLine(this);
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

        public int Capacity { get { return _capacity; } set { _capacity = value; _cars = new Car[value]; } }
        public string Address { get { return _address; } set { _address = value; } }


        public Garage()
        {
            _address = "nieznany";
            _cars = null;
            _carsCount = 0;
            _capacity = 0;
        }

        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _cars = new Car[capacity];

        }




        public void CarIn(Car car)
        {
            if (_carsCount == _capacity)
            {
                Console.WriteLine("Garage overfull");
            }
            else
            {

                _cars[_carsCount] = car;
                _carsCount++;

            }
        }

        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Garage is empty!");
                return null;
            }
            _carsCount--;
            Car car = new Car(_cars[_carsCount]);
            _cars[_carsCount] = null;
            return car;

        }

        public override string ToString()
        {
            string result = $"Address: {_address}, CarsCount: {_carsCount}, Capacity: {_capacity}, Cars:" + '\n';
            foreach (Car CAR in _cars)
            {
                if (CAR == null)
                    break;
                result += CAR.ToString() + '\n';
            }
            return result;
        }

        public void Details()
        {
            Console.WriteLine(this);

        }


    }

    public class Person
    {
        private string[] _registrationNumber;

        public static int MaxCarCount { get; set; } = 3;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount { get; set; }

        public Person()
        {
            FirstName = "nieznany";
            LastName = "nieznany";
            Address = "nieznany";
            CarsCount = 0;
            _registrationNumber = new string[MaxCarCount];
        }

        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            _registrationNumber = new string[MaxCarCount];

        }

        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            _registrationNumber = new string[MaxCarCount];
            for (int i = 0; i < CarsCount; i++)
            {
                _registrationNumber[i] = cars[i].RegistrationNumber;
            }

        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {

            if (CarsCount >= MaxCarCount)
            {
                Console.WriteLine("The amount of cars is at the maximum.");
                return;
            }
            _registrationNumber[CarsCount++] = registrationNumber;

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
                if (_registrationNumber[i] == registrationNumber)
                {
                    for (int j = i; j < CarsCount - 1; j++)
                    {
                        _registrationNumber[j] = _registrationNumber[j + 1];
                    }
                    CarsCount--;
                    return;
                }
            }
            Console.WriteLine("Car not found.");
        }

        public override string ToString()
        {
            string res = $"{FirstName} {LastName} {Address}\nCars: ";
            for (int i = 0; i < CarsCount; i++)
            {
                res += _registrationNumber[i] + ' ';
            }
            return res;
        }

        public void Details()
        {
            Console.WriteLine(this);
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
            car1.RegistrationNumber = "AA1488";
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
