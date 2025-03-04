using System;
class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Toyota", "Corolla", 4, 1.8, 6.5);
        Car car2 = new Car("Ford", "Mustang", 2, 5.0, 12.0);

        car1.DisplayCarInfo();
        Console.WriteLine();
        car2.DisplayCarInfo();
        Console.WriteLine();

        double distance = 300;
        double fuelPricePerLiter = 5.5;

        double consumption = car1.CalculateConsump(distance);
        double cost = car1.CalculateCost(distance, fuelPricePerLiter);

        Console.WriteLine($"Car 1 consumption for {distance}km: {consumption}L");
        Console.WriteLine($"Car 1 fuel cost for {distance}km: {cost} zł");
        Console.WriteLine();

        Car.DisplayCarCount();
    }
}
