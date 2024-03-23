using System.Net;
using System.Runtime.CompilerServices;

namespace Lab1.App
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private string _registrationNumber;
        private static int _carCount = 0;
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
        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }

        public Car()
        {
            _brand = "nieznana";
            _model = "nieznany";
            _doorCount = 0;
            _engineVolume = 0;
            _avgConsump = 0.0;
            _registrationNumber = "nieznany";
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
        public double CalculateConsump(double roadLength)
        {
            double consump = (AvgConsump * roadLength) / 100.0;
            return consump;
        }
        public double CalculateCost(double petrolCost, double roadLength)
        {
            double cost = CalculateConsump(roadLength) * petrolCost;
            return cost;
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:{_doorCount}, EngineVol: {_engineVolume}, AvgConsump:{_avgConsump}";
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
        private Car[]? _cars;
        private string _adress;
        private int _carsCount;
        private int _capacity;

        public Garage()
        {
            _cars = null;
            _adress = "nieznany";
            _carsCount = 0;
            _capacity = 0;
        }
        public string Address { get => _adress; set => _adress = value; }
        public int Capacity { get => _capacity; set { _capacity = value; _cars = new Car[value]; } }
        public Garage(string adress, int capacity)
        {
            _cars = new Car[capacity];
            _adress = adress;
            _capacity = capacity;
        }
        public void CarIn(Car car)
        {
            if (_carsCount >= _capacity)
            {
                Console.WriteLine("Garaż jest zapełniony!");
                return;
            }

            _cars[_carsCount++] = car;
        }

        public Car CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Garaż jest pusty!");
                return null;
            }

            Car car = _cars[_carsCount - 1];
            _cars[_carsCount - 1] = null;
            _carsCount--;

            return car;
        }
        public override string ToString()
        {
            string result = $"Garage: {Address}, Pojemność: {Capacity}, Zaparkowane samochody: {_carsCount}\n";

            foreach (Car car in _cars)
            {
                if (car != null)
                {
                    result += car.ToString() + "\n";
                }
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
        private string[]? _registrationNumbers = new string[3];
        public int MaxCountCar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CarsCount { get; set; }
        public string Address { get; set; }
        public Person()
        {
            FirstName = "";
            LastName = "";
            Address = "";
            CarsCount++;

        }
        public Person(string firstName, string lastName, string address, Car[] car)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;

            CarsCount = car.Length;
            for (int i = 0; i < car.Length; i++)
            {
                _registrationNumbers[i] = car[i].RegistrationNumber;
            }
        }
        public void addCarRegistrationNumber(string register)
        {
            if (_registrationNumbers.Contains(register))
            {
                Console.WriteLine("istenieje rejestracji");
            }
            if (CarsCount >= 3)
            {
                Console.WriteLine("możesz mieć maksymalnie 3 samochody");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == CarsCount)
                    {
                        _registrationNumbers[i] = register;
                        CarsCount++;
                        break;
                    }
                }
            }
        }
        public void RemoveCarRegistrationNumber(string register)
        {
            if (!_registrationNumbers.Contains(register))
            {
                Console.WriteLine("nie ma takiej rejestracji");
            }
            else
            {
                for (int i = 0; i < CarsCount; i++)
                {
                    if (register == _registrationNumbers[i])
                    {
                        _registrationNumbers[i] = null;
                        CarsCount--;
                    }
                }
            }
        }
        public override string ToString()
        {
            return "Imię: " + FirstName + ", Nazwisko: " + LastName + ", Numery rejestracyjne: " + string.Join(", ", _registrationNumbers); ;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
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
        }
    }
}