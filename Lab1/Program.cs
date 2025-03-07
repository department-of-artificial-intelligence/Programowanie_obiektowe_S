using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main()
        {
            //Testing Car class
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

            //Testing Garage class
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

            // Testing Person class
            Person person1 = new Person("Jan", "Kowalski", "ul. Polna 3");
            person1.Details();

            person1.AddCarRegistrationNumber("KR12345");
            person1.AddCarRegistrationNumber("WE1234");
            person1.AddCarRegistrationNumber("WA9876");

            Console.WriteLine(person1);

            person1.AddCarRegistrationNumber("PO1234");

            person1.RemoveCarRegistrationNumber("WE1234");

            person1.Details();

            person1.AddCarRegistrationNumber("PO1234");
            person1.Details();

            Console.WriteLine("\r\n=========================================\r\n");

            Car car3 = new Car("Toyota", "Corolla", 4, 1.8f, 6.0, "GD12345");
            Car car4 = new Car("Honda", "Civic", 4, 1.6f, 7.0, "LR9876");

            Person person2 = new Person("Anna", "Nowak", "ul. Wrzosowa 5", new Car[] { car3, car4 });
            person2.Details();
            Console.WriteLine(person2);
        }
    }
}
