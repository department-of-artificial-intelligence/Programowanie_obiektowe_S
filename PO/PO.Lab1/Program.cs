using System.Net;
using System.Reflection;

Console.WriteLine("Hello, World!");
public class Car {
  
    private string _brand;
    private string _model;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsump;
    private static int _carCount;

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
    public Car() 
    {
        Brand = string.Empty;
        Model = " ";
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
        this.ToString();
    }

}
