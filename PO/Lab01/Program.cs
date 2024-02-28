// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Sockets;

namespace lab01;

public class Car {

    protected string _brand = "DefaultBrand";
    protected string _model = "DefaultModel";
    protected int _doorCount = 4;
    protected float _engineVolume = 0;
    protected double _avgConsump = 0;
    protected string _registrationNumber = "DefaultRegistrationNumber";

    public static uint _carCount;

    public string Brand { get =>_brand; set =>_brand = value; }
    public string Model { get => _model; set => _model = value; }
    public int DoorCount { get => _doorCount; set => _doorCount = value; }
    public float EngineVolume { get => _engineVolume; set => _engineVolume = value; }
    public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }
    public string RegistrationNumber { get => _registrationNumber; set => _registrationNumber = value; }
    public Car() { _carCount++; }
    public Car(string brand = "DefaultBrand", string model = "DefaultModel", int doorCount = 0, float engineVolume = 0, double avgConsump = 0, string registrationNumber = "DefaultRegistrationNumber"){
        Brand = brand; Model = model; DoorCount = doorCount; EngineVolume = engineVolume; AvgConsump = avgConsump; RegistrationNumber = registrationNumber;
        _carCount++;
    }
    ~Car() { _carCount--; }

    public double CalculateConsump(double roadLength) {
        return roadLength / 100 * _avgConsump;
    }

    public double CalculateCost(float roadLength, float petrolCost) {
        return petrolCost * CalculateConsump(roadLength);
    }

    public override string ToString()
    {
        return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:" +
            $"{ _doorCount}, EngineVol: { _engineVolume}, AvgConsump:" +
            $"{ _avgConsump}";
    }

    public void Details() {
       Console.WriteLine(this.ToString()); 
    }
    public static void DisplayCarCount() { Console.WriteLine(_carCount); }
}

public class Garage
{
    protected Car[] _cars = [];
    protected string _address = "";
    protected int _carsCount;
    protected int _capacity;

    public int Capacity {get =>_capacity;set=>_capacity = value;}
    public string Address { get => _address; set => _address = value; }

    public Garage() { }
    public Garage(string address = "",int capacity = 0)
    {
        _address = address;_capacity = capacity;
    }
    public void CarIn(Car car)
    {
        if (_capacity <= _carsCount){
            throw new Exception("Garage is full!");
        }
        _capacity++;
        _cars.Append(car);
    }

    public Car CarOut()
    {
        var cars = new List<Foo>(_cars);
        var result = cars[_carsCount - 1];
        cars.RemoveAt(_carsCount-1);
        return result;
    }
}

public class Program
{
    public static int Main(string[] args)
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
        return 0;
    }
}