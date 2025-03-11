using System.Xml.Linq;

namespace Lab1
{


    internal class Program
    {
        static void Main(string[] args)
        {
        Car car1 = new Car();
        car1.Details(); car1.Brand = "Fiat";
        car1.Model = "126p"; car1.DoorCount = 2; 
        car1.EngineVolume = 650; car1.AvgConsump = 6.0;
        car1.RegistrationNumber = "KR12345"; car1.Details();
        Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d, "WE1234");
        car2.Details(); Console.WriteLine(car1);
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
        Person person1 = new Person();
        Person person2 = new Person("Adam","Bednar","Walcowa");
        Car car3 = new Car("Fajne","Szybkie",5,5,5,"AB9999");
        Car car4 = new Car("Fajne", "Szybkie", 5, 5, 5, "AB3333");
        Car car5 = new Car("Fajne", "Szybkie", 5, 5, 5, "AB7777");
        Car car6 = new Car("Fajne", "Szybkie", 5, 5, 5, "AB8888");
        Car[] samochody = new Car[3];
        Car[] samochody1 = new Car[4];
        samochody[0] = car1;
        samochody[1] = car2;
        samochody[2] = car3;
        samochody1[0] = car1;
        samochody1[1] = car2;   
        samochody1[2] = car3;
        samochody1[3] = car4;
        Person person3 = new Person("Andrew", "Kolanko", "New Street", samochody);
        Person person4 = new Person("Ala", "Kota", "Juhowo", samochody1);
        person3.Details();
        person3.RemoveCarRegistrationNumber("AB9999");
        person1.AddCarRegistrationNumber("XDDDD");
        person1.Details();
        person1.AddCarRegistrationNumber("1XDDDD");
        person1.AddCarRegistrationNumber("2XDDDD");
        person1.Details();
        person1.AddCarRegistrationNumber("2XDDDD");
        person1.Details();
        person2.Details();
        person3.Details();
        person1.RemoveCarRegistrationNumber("XDDDD");
        person1.RemoveCarRegistrationNumber("1XDDDD");
        person1.RemoveCarRegistrationNumber("2XDDDD");
        person1.Details();
    }
    }
}
