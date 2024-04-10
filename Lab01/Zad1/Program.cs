using System;

class Car
{
    private string _brand;
    private string _model;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsump;
    private string _registrationNumber;
    private static int _carCount = 0;

    public string Brand { get; set; }
    public string Model { get; set; }
    public int DoorCount { get; set; }
    public float EngineVolume { get; set; }
    public double AvgConsump { get; set; }
    public string RegistrationNumber { get; set; }

    Car()
    {
        _brand = "nieznana";
        _model = "nieznany";
        _doorCount = 0;
        _engineVolume = 0;
        _avgConsump = 0.0;
    }

    Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
        _registrationNumber = registrationNumber;
        _carCount += 1;
    }

    public double CalculateConsump(double roadLength)
    {
        return (_avgConsump * roadLength) / 100.0;
    }

    public double CalculateCost(double roadLength, double petrolCost)
    {
        return CalculateConsump(roadLength) * petrolCost;
    }

    public override string ToString()
    {
        return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:{_doorCount}, EngineVol: {_engineVolume}, AvgConsump:{_avgConsump}, RegistrationNumber: {_registrationNumber}";
    }

    public void Details()
    {
        Console.WriteLine(ToString());
    }

    public static void DisplayCarCount()
    {
        Console.WriteLine(_carCount);
    }

    public static void Main()
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


