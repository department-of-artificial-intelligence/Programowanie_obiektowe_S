// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography;
using System;
using System.Security.AccessControl;

namespace lab1;
public class Car
{
    private string _brand = string.Empty;
    private string _model = string.Empty;
    private int _doorCount = 4;
    private float _engineVolume = 0;
    private double _avgConsump = 0;
    private string _registrationNumber = string.Empty;

    private static uint _carCount = 0;
    public string Brand { get => _brand; set => _brand = value; }
    public string Model { get => _model; set => _model = value; }
    public int DoorCount { get => _doorCount; set => _doorCount = value; }
    public float EngineVolume { get => _engineVolume; set => _engineVolume = value; }
    public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }
    public string RegistrationNumber { get => _registrationNumber; set => _registrationNumber = value; }

    public Car() { _carCount++; }
    public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
    {
        Brand = brand;
        Model = model;
        DoorCount = doorCount;
        EngineVolume = engineVolume;
        AvgConsump = avgConsump;
        RegistrationNumber = registrationNumber;
        _carCount++;
    }
    ~Car() { _carCount--; }

    public double CalculateConsump(double roadLength)
    {
        return (AvgConsump * roadLength) / 100.0;
    }
    public double CalculateCost(double roadLength, double petrolCost) 
    {
        return CalculateConsump(roadLength) * petrolCost;
    }
    public override string ToString()
    {
        return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}," +
            $" AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
    }
    public void Details()
    {
        Console.WriteLine(this.ToString());
    }

    public static void DisplayCarCount() 
    {
        Console.WriteLine(_carCount);
    }
}

public class Garage
{
    private Car[] _cars = [];
    private string _adress = string.Empty;
    private int _carsCount = 0;
    private int _capacity = 0;

    public int Capacity { get => _capacity; set => _capacity = value; }
    public string Address { get => _adress; set => _adress = value; }
    Garage() { }
    Garage(string address, int capacity)
    {
        Capacity = capacity;
        Address = address;
    }

    public void CarIn(Car car)
    {
        if (_capacity <= _carsCount)
        {
            throw new Exception("Garage is full!");
        }
        _capacity++;
        _cars.Append(car);

    }

    public Car CarOut()
    {
        if (_capacity == 0) {
            throw new Exception("Garage is empty!");
        }
        var cars = new List<Car>(_cars);
        var result = cars[cars.Count - 1];
        cars.RemoveAt(cars.Count - 1);
        _carsCount--;
        return result;
    }

    public override string ToString()
    {
        return $"Garage | Address: {_adress}, Cars count: {_carsCount}, Capacity:{_capacity}\n";
        /*foreach (Car car in _cars)
        {
            if (car == null) break;
            result += car.ToString() + '\n';
        }
        return result;*/
    }
    public void Details()
    {
        Console.WriteLine(this.ToString());
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
        car1.RegistrationNumber = "KR12345";
        car1.Details();
        Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d, "WE1234");
        car2.Details();
        Console.WriteLine(car1);
        double routeConsumption = car2.CalculateConsump(500);
        Console.WriteLine($"Route consumption: {routeConsumption}l");
        double routeCost = car2.CalculateCost(500, 5);
        Console.WriteLine($"Route cost: {routeCost}zl");
        Car.DisplayCarCount();
        Console.WriteLine("\r\n=========================================\r\n");
        Garage garage1 = new Garage();
        garage1.Address = "ul. Garażowa 1";
        garage1.Capacity = 1;
        Garage garage2 = new Garage("ul. Garażowa 2", 2);
        garage1.CarIn(car1);
        garage1.Details();
        garage1.CarIn(car2);
        garage2.CarIn(car2);
        var movedCar = garage1.CarOut();
        garage2.CarIn(movedCar);
        garage2.Details();
        garage1.Details();
        garage2.CarOut();
        garage2.Details();
        garage2.CarOut();
        garage2.CarOut();
        garage2.Details();
        garage1.Details();
        Console.WriteLine("\r\n=========================================\r\n");
        return 0;
    }

}

