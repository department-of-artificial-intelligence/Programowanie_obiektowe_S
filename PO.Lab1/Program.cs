using System.Numerics;
using System;

public class Car
{
    private string _brand;
    private string _model;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsump;
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
    { get { return _doorCount; }  set { _doorCount = value; } }
    public float EngineVolume
    { get { return _engineVolume; } set { _engineVolume = value; } }
    public double AvgConsump {  
        get { return _avgConsump; } set { _avgConsump = value; } }

    public Car()
    {
        _brand = "Default";
        _model = "Default";
        _doorCount = 0;
        _engineVolume = 0;
        _avgConsump = 0;
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

    public double CalculateConsump(double roadLength)
    {
        return (roadLength * _avgConsump) / 100.0;
    }
    public double CalculateCost(double length, double gasPrice) 
    {
        return gasPrice * CalculateConsump(length);
    }

    public override string ToString()
    {
        return $"\nBrand: {_brand}\nModel: {_model}\nDoor Count: {_doorCount}\nEngine Volume: {_engineVolume}\nAvarage Consumption: {_avgConsump}\n";
    }

    public void Details()
    {
        Console.WriteLine(this);
    }

    public static void DisplayCarCount()
    {
        Console.WriteLine($"Count of cars: {Car._carCount}");
    }
}

internal class Program
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

        Console.ReadKey();
    }
}
