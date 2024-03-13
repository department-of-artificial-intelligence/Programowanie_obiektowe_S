using System.Reflection;

public class Car
{
   private string _brand;
    private string _model;
    private string _RegistrationNumber;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsump;
    private static int _carCount;
    public Car()
    {
        _brand = "";
        _model = "";
        _doorCount = 0;
        _engineVolume = 0;
        _avgConsump = 0;
        _carCount++;
        Console.WriteLine("konstruktor domyślny");
    }
    public Car(string brand, string model, int doorCount,
        float engineVolume, double avgConsump,string RegistrationNumber)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
        _RegistrationNumber = RegistrationNumber;
        _carCount++;
    }
    public double CalculateConsump(double s)
    {
        return (_avgConsump * s) / 100;
    }
    public double CalculateCost(double petrolCost,double roadLength)
    {
        return CalculateConsump(roadLength) * petrolCost;
    }
    public string Brand { get => _brand; set => _brand = value; }
    public string Model { get => _model; set => _model = value; }
    public string RegistrationNumber { get => _RegistrationNumber; set => _RegistrationNumber = value; }
    public int DoorCount { get => _doorCount; set => _doorCount = value; }
    public float EngineVolume { get => _engineVolume; set => _engineVolume = value; }
    public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }
    public int CarCount { get => _carCount; set => _carCount = value; }
    public void Details()
    {
        Console.WriteLine(this.ToString());
    }
    public static int Carcount => _carCount;
    public static void DisplayCarCount()
    {
        Console.WriteLine($"Car count: {Carcount}");
    }

    public override string ToString()
    {
        return $"Brand: {_brand}, Model: {_model}, " +
            $"DoorCount: {_doorCount}, EngineValume: {_engineVolume}," +
            $"AvgConsump: {_avgConsump}";
    }
}
public class Garage
{
    private string _address;
    private int _carsCount;
    private int _capacity;
    private Car[] _car;
    public int Capacity { get => _capacity; set { _capacity = value;_car = new Car[value]; } }
    public Garage()
    {
        _address = "";
        _carsCount = 0;
        _capacity = 0;
        _car = new Car[_capacity];
    }
    public Garage(string address,int capacity)
    {
        _address = address;
        _capacity = capacity;
        _car = new Car[_capacity];
        _carsCount++;
    }
    public string Address { get => _address; set => _address = value; }
   
    public void CarIn(Car c)
    {
        if (_carsCount == _capacity)
        {
            Console.WriteLine("jest pełny");
        }
        else {
            _car[_carsCount] = c;
            _carsCount++;
        }
    }
    public Car? CarOut()
    {
        if (_carsCount ==0)
        {
            Console.WriteLine("jest pusty");
            return null;
        } else 
        {
            Car car = _car[_carsCount - 1];
            _car[_carsCount - 1] = null;
            _carsCount--;
            return car;
        }

       
    }
    public override string ToString()
    {
        return $"Address: {_address}, _capacity: {_capacity}";
    }
    public void Details()
    {
        Console.WriteLine(this.ToString());
        foreach(Car e in _car)
        {
            if (e != null)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
public class Person
{
    private string[]? _registrationNumbers = new string[3];
  
    //private Car[] _car = new Car[3];
    public int MaxCountCar { get ; set; }
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
    public Person(string firstName,string lastName,string address, Car[] car)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;

        CarsCount=car.Length;
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
        else {
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
                    //MaxCountCar--;
                    CarsCount--;
                }

            }
        }
    }
    public override string ToString()
    {
        return  "Imię: " + FirstName + ", Nazwisko: " + LastName + ", Numery rejestracyjne: " + string.Join(", ", _registrationNumbers); ;
    }
    public void Details()
    {
        Console.WriteLine(this.ToString());
    }
}
class Program {
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
        Car[] cars = {car1,car2 };
        Person p = new Person("Marcin","Maj","ul.gajowa 2", cars);
        p.addCarRegistrationNumber("32456f");
        p.addCarRegistrationNumber("S245");
        p.addCarRegistrationNumber("21435");
        p.addCarRegistrationNumber("32456f");
        p.RemoveCarRegistrationNumber("32456f");
        p.RemoveCarRegistrationNumber("2222");
        p.Details();
    }
}
