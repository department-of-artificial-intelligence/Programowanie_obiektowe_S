﻿using System;
using System.Runtime.ConstrainedExecution;

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

    public Car()
    {
        _brand = "nieznana";
        _model = "nieznany";
        _doorCount = 0;
        _engineVolume = 0;
        _avgConsump = 0.0;
    }

    public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
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
}

class Garage
{
    private Car[] _cars;
    private string _address;
    private int _capacity;
    private int _carsCount = 0;

    public int Capacity
    {
        get
        {
            return _capacity;
        }
        set
        {
            _capacity = value;
            _cars = new Car[value];
        }
    }
    public string Address { get; set; }

    public Garage()
    {
        _cars = null;
        _address = "nieznany";
        _capacity = 0;
    }

    public Garage(string address, int capacity)
    {
        _address = address;
        _capacity = capacity;
        _cars = new Car[_capacity];
    }

    public void CarIn(Car car)
    {
        if (_carsCount <= _capacity)
        {
            Console.WriteLine($"Garaz zapelniony");
        }
        else
        {
            _cars[_carsCount] = car;
            _carsCount++;
        }
    }

    public Car CarOut()
    {
        if (_carsCount == 0)
        {
            Console.WriteLine($"Garaz pusty");
            return null;
        }
        else
        {
            Car car = _cars[_carsCount - 1];
            _carsCount--;
            return car;
        }
    }

    public override string ToString()
    {
        string curr_cars_string = "";
        foreach (Car car in _cars)
            if (car != null)
            {
                curr_cars_string += car.ToString() + '\n';
            }
        return $"Address:{_address} | Capacity:{_capacity} | Cars:{curr_cars_string}";
    }

    public void Details()
    {
        Console.WriteLine(ToString());
    }
}

class Person
{
    private string[] _registrationNumbers;

    public static int MaxCarCount { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public int CarsCount { get; set; }

    public Person ()
    {
        _registrationNumbers = new string[0];
        FirstName = "nieznane";
        LastName = "nieznane";
        Address = "nieznany";
        CarsCount = 0;
    }

    public Person (string firstName, string lastName, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public Person (string firstName, string lastName, string address, Car[] cars)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
        _registrationNumbers = new string[MaxCarCount];
        for (int i = 0; i < MaxCarCount; i++)
        {
            _registrationNumbers[i] = cars[i].RegistrationNumber;
            CarsCount++;
        }

    }

    public void AddCarRegistrationNumber(string registrationNumber)
    {
        for (int i = 0; i < MaxCarCount; i++)
        {
            if (_registrationNumbers[i] == null)
            {
                _registrationNumbers[CarsCount] = registrationNumber;
                CarsCount++;
                return;
            }
        }

    }

    public void RemoveCarRegistrationNumber(string registrationNumber)
    {
        for (int i = 0; i < CarsCount; i++)
        {
            if (_registrationNumbers[i] == registrationNumber)
            {
                _registrationNumbers[i] = null;
                CarsCount--;
                return;
            }
        }

    }

    public override string ToString()
    {
        string rejestracje = "";
        if (CarsCount == 0)
        {
            return $"Osoba {FirstName} {LastName} o adresie {Address} nie posiada żadnych pojazdów";
        }
        else
        {
            foreach (var car in _registrationNumbers)
            {
                if (car != null)
                {
                    rejestracje += $" {car} \n";
                }
            }
            return $"Osoba {FirstName} {LastName} o adresie {Address} posiada najstępujące pojazdy\n {rejestracje}";
    }

    }
    public void Details()
    {
        Console.WriteLine(ToString());
    }
}

internal class Program
{
    static void Main(string[] args)
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
        Console.WriteLine("Zad 3 \n");
        Car car3 = new Car("Syrena", "104", 2, 0.8f, 7.6, "WE4321");
        Person person = new Person("Jan", "Kowal", "ul. Kwiatowa 1, Częstochowa");
        person.AddCarRegistrationNumber("AB1234");
        person.AddCarRegistrationNumber("AC1234");
        person.AddCarRegistrationNumber("AD1234");
        person.AddCarRegistrationNumber("AE1234");
        person.RemoveCarRegistrationNumber("AE1234");
        person.RemoveCarRegistrationNumber("AD1234");
        person.RemoveCarRegistrationNumber("AC1234");
        person.RemoveCarRegistrationNumber("AB1234");
        person.Details();
        Car[] cars = new Car[]
        {
                car1,
                car2,
                car3,
                new Car("Syrena", "104", 2, 0.8f, 7.6, "WE4321")
        };
        new Person("Maja", "Nowak", "ul. Wesoła 5, Częstochowa", cars).Details();
        Console.WriteLine("\r\n=========================================\r\n");

    }
}