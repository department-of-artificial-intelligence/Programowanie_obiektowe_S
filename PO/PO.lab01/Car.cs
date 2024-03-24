using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Car
{
    private string _brand = null!;
    private string _model = null!;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsump;
    private static int carCount = 0;
    private string _registrationNumber = null!;

    public string Brand
    { 
        get { return _brand; } 
        set { _brand = value; }
    }

    public string Model { get => _model; set { _model = value; } }
    public int DoorCount {  get { return _doorCount; } set {  _doorCount = value; } }
    public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
    public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }
    public string RegistrationNumber { get => _registrationNumber; set { _registrationNumber = value; } }
    
    public Car()
    {
        _brand = "Brak marki";
        _model = "Brak modelu";
        _doorCount = 0;
        _engineVolume = 0.0f;
        _avgConsump = 0.0d;
        carCount++;
    }
    public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
        carCount++;
    }
    public override string ToString()
    {
        return $"Marka: {_brand}, model: {_model}, liczba drzwi: {_doorCount}, pojemność silnika; {_engineVolume}" +
            $", średnie spalanie: {_avgConsump}";
    }
    public double CalculateConsump(double roadLength)
    { 
        return (_avgConsump * roadLength)/100.0d;
    }

    public double CalculateCost(double roadLength, double petrolCost)
    {
        return CalculateConsump(roadLength) * petrolCost;
    }
    public void Details()
    {
        Console.WriteLine(this.ToString());
    }
    public static void DisplayCarCount()
    {
        Console.WriteLine(carCount);
    }
}
