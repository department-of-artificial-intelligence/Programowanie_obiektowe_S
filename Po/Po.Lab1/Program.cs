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
    public void CarIn(Car c)
    {
        if (_carsCount == 0)
        {
            Console.WriteLine("jest pusty");
        }
        else if (_carsCount >= 1)
        { 
            
        }
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
    }
}
