// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography;
using System;
using System.Security.AccessControl;
using System.Collections.Generic;

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
    Car[] _cars;   
    string _adress = string.Empty;
    int _carsCount = 0;
    int _capacity = 0;

    public int Capacity { get { return _capacity; } 
        
        set
        {
            if(value < _carsCount )
            {
                throw new Exception("Error!");
            }
            Car[] cars = new Car[value];
            for (int i = 0; i < _carsCount; i++)
            {
                cars[i] = _cars[i];
            }
            _capacity = value;
            _cars = cars;
       } 
    }
    public string Address { get => _adress; set => _adress = value; }
    public Garage() {
        _cars = [];
    }
    public Garage(string address, int capacity)
    {
        _capacity = capacity;
        _adress = address;
        _cars = new Car[capacity];

    }

    public void CarIn(Car car)
    {
        if (_capacity <= _carsCount)
        {
            throw new Exception("Garage is full!");
        }
        _cars[_carsCount] = car;
        _carsCount++;

        

    }

    public Car? CarOut()
    {
        if (_carsCount == 0) {
            Console.WriteLine("Garage is empty!");
            return null;
        }
        _carsCount--;
        var result = _cars[_carsCount];
        return result;
    }

    public override string ToString()
    {
        string result = $"Garage | Address: {_adress}, Cars count: {_carsCount}, Capacity:{_capacity}\n";
        foreach (var car in _cars)
        {
            if(car == null) break;
            result += car.ToString();
        }
        return result;
    }
    public void Details()
    {
        Console.WriteLine(ToString());
    }

}

public class Person
{
    public string[]? _registrationNumber;  
    public string _firstName;
    public string _lastName;
    public string _address;
    public static int _maxCarCount;
    public int _carsCount;

    public Person()
    {
        _registrationNumber = new string[_maxCarCount];
        _firstName = "Default";
        _lastName = "Default";
        _address = "Default";
        _maxCarCount = 3;
        _carsCount = 0;
    }

    public Person(string firstName, string lastName, string address) 
    {
        _registrationNumber = new string[_maxCarCount];
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
        _carsCount = 0;
        _maxCarCount = 3;
    }

    public Person(string firstName, string lastName, string address, Car[] cars)
    {
        _registrationNumber = new string[_maxCarCount];
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
        _carsCount = 0;
        _maxCarCount = 3;
        foreach (Car a in cars) 
        {
            if(_carsCount < _maxCarCount)
            {
                _registrationNumber[_carsCount] = new string(a.RegistrationNumber);
                ++_carsCount;
            }
            else
            {
                break;
            }
        }
    }

    public int MaxCarCount {  get { return _maxCarCount; } set { _maxCarCount = value; } }
    public string FirstName { get { return _firstName; } set { _firstName = value; } }
    public string LastName { get { return _lastName; } set { _firstName = value; } }
    public string Address { get { return _address; } set { _address = value; } }
    public int CarsCount { get { return _carsCount; } set { _carsCount = value; } }



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
        garage1.Capacity = 2;
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

