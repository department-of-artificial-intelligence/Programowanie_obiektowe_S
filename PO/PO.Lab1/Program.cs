// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography;

public class Car
{
    private string _brand;
    private string _model;
    private int _doorCount;
    private double _engineVolume;
    private double _avgConsump;

    private static int _carCount = 0;

    public Car(string brand, string model, int doorCount, double engineVolume, double avgConsump)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
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
}

