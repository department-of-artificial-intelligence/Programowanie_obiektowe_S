using System;

public class Car {
    private string _brand;
    private string _model;
    private int _doorCount;
    private float _engineVolume;
    private double _avgComsuption;
    private static int carCount;

    public string Brand {
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
        get { return carCount; }
        set { carCount = value; }
    }
    public float EngineVolume
    {
        get { return _engineVolume; }
        set { _engineVolume = value; }
    }
    public double AvgComsuption
    { 
        get { return _avgComsuption;}
        set {  _avgComsuption = value; }
    }

    public Car()
    { 
        _brand = string.Empty;
        _model = string.Empty;
        _doorCount = 0;
        _engineVolume = 0;
        _avgComsuption = 0;
        carCount++;
    }
    public Car(string brand, string model, int doorCount, float engineVolume, double avgComsuption)
    {   
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgComsuption = avgComsuption;
        carCount++;
    }

    public double CalculateConsump(double roadLenght)
    {
        return (roadLenght/100) * _avgComsuption;
    }

    public double CalculateCost(double roadLenght, double petrolCost)
    { 
        return (roadLenght/100) * _avgComsuption * petrolCost/100;
    }

    public override string ToString()
    {
        return $"Marka: {_brand} , Model: {_model} , Ilość drzwi: {_doorCount} , Pojemność silnika: {_engineVolume} , Przeciętne spalanie: {_avgComsuption} ";
    }

    public void Details()
    {
        Console.WriteLine(this);
    }

    public static void DisplayCarCount()
    {
        Console.WriteLine(carCount);
    }

    static void Main()
    {
        Car car1 = new Car();
        car1.Details();
        car1.Brand = "Fiat";
        car1.Model = "126p";
        car1.DoorCount = 2;
        car1.EngineVolume = 650;
        car1.AvgComsuption = 6.0;
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

    }



}


