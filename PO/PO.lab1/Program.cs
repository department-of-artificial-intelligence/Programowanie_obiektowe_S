﻿using System;
using PO.lab1;
class Program 
{ 
    static void Main(string[]argv) {
        Car car1 = new Car();
        car1.Details();
        car1.Brand = "Fiat";
        car1.Model = "126p";
        car1.DoorCount = 2;
        car1.EngineVolume = 650;
        car1.AvgConsump = 6.0;
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

    }
}

