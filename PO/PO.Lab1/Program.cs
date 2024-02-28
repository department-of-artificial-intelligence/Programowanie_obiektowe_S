// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.AccessControl;

Console.WriteLine("Hello, World!");

public class Car
{
    private string _brand;
    private string _model;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsump;
    private static int _carCount = 0;

    public string Brand { get; set; }
    public string Model { get; set; }
    public int DoorCount { get; set; }
    public float EngineVolume { get; set; }
    public double AvgConsump { get; set; }
    public Car()
    {
        Brand = "nieznana";
        Model = "nieznany";
        DoorCount = 0;
        EngineVolume = 0;
        AvgConsump = 0.0;
    }
    public Car(string brand,
               string model,
               int doorCount,
               float engineVolume,
               double avgConsump)
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
        return  $"Car | Brand: {_brand}," +
                $" Model: {_model}, " +
                $"NumOfDoors:{ _doorCount}," +
                $" EngineVol: { _engineVolume}," +
                $" AvgConsump: { _avgConsump}," +
                $" RegistrationNumber: { _registrationNumber}";
    }

    double CalculateConsump(double roadLength)
    {
        consump = (avgConsump * roadLength) / 100.0;
    }

    double CalculateCost(double roadLength, double pertolCost) 
    {
        cost = consump * petrolCost;
        return cost;
    }

    void Details()
    {
        Console.WriteLine($"{this.Brand}" +
                          $"{this.Model}" +
                          $"{this.DoorCount}" +
                          $"{this.EngineVolume}") +
                          $"{this.AvgConsump}")
    }

    void DisplayCarCount()
    {

    }
}

