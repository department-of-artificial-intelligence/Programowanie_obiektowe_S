using System;

public class Car
{
    private string _brand;
    private string _model;
    private int _doorCount;
    private double _engineVolume;
    private double _avgConsump;
    private string _registrationNumber;

    private static int _carCount = 0;

    public Car()
    {
        _brand = "Unknown";
        _model = "Unknown";
        _doorCount = 0;
        _engineVolume = 0.0;
        _avgConsump = 0.0;
        _registrationNumber = "Unknown";
        _carCount++;
    }

    public Car(string brand, string model, int doorCount, double engineVolume, double avgConsump, string registrationNumber)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
        _registrationNumber = registrationNumber;
        _carCount++;
    }

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

    public double EngineVolume
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
    public double CalculateConsump(double distance)
    {
        return (_avgConsump * distance) / 100;
    }

    public double CalculateCost(double distance, double fuelPricePerLiter)
    {
        double consumption = CalculateConsump(distance);
        return consumption * fuelPricePerLiter;
    }

    public void Details()
    {
        Console.WriteLine($"Brand: {_brand}");
        Console.WriteLine($"Model: {_model}");
        Console.WriteLine($"Door Count: {_doorCount}");
        Console.WriteLine($"Engine Volume: {_engineVolume}L");
        Console.WriteLine($"Average Consumption: {_avgConsump}L/100km");
        Console.WriteLine($"Registration Number: {_registrationNumber}");
    }

    public override string ToString()
    {
        return $"Car: {_brand} {_model}, Doors: {_doorCount}, Engine: {_engineVolume}L, Consumption: {_avgConsump}L/100km, Registration: {_registrationNumber}";
    }

    public static void DisplayCarCount()
    {
        Console.WriteLine($"Number of cars created: {_carCount}");
    }
}