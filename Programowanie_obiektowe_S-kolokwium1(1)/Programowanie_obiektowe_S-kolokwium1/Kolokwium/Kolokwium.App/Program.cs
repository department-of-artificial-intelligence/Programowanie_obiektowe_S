using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.BLL
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car truck1 = new Truck("Mercedes", "x21,", "SC 12345", 10);
            Console.WriteLine(truck1.ToString());
            truck1.Display();
            Car truck2 = new Truck("Volvo", "v40,", "SC 54321", 15);
            Car regularCar1 = new RegularCar("Audi", "A4", "WW 12345", 5);
            Console.WriteLine(regularCar1.ToString());
            regularCar1.Display();
            Car regularCar2 = new RegularCar("Citroen", "C3", "WA 12312", 3);
            Person employee = new Employee("Jan", "Kowalski", new DateTime(1978, 1, 1), DateTime.Now.AddHours(8));
            Console.WriteLine(employee);
            employee.Display();
            Client client1 = new Client("Adam", "Nowicki", new DateTime(1988, 11, 11), DateTime.Now.AddHours(4), truck1, 30);
            Console.WriteLine(client1);
            employee.Display();
            Person client2 = new Client("Michał", "Iksinski", new DateTime(1977, 11, 11), DateTime.Now.AddHours(4), truck2, 10);
            Person client3 = new Client("Patryk", "Igrekowski", new DateTime(1956, 11, 11), DateTime.Now.AddHours(4), regularCar1, 5);
            Client client4 = new Client("Piotr", "Kowalski", new DateTime(1958, 11, 11), DateTime.Now.AddHours(4), regularCar2, 5);
            Parking<Car> carParking = new Parking<Car>("Częstochowa Armii krajowej 22", new List<Car>() {
                truck1,
                truck2,
                regularCar1
            }, new List<Client>() {
                client1,
                client2 as Client,
                client3 as Client
}, new List<Employee>() { employee as Employee });
            Console.WriteLine(carParking);
            Console.WriteLine("==========================ADD CAR===================================");
            carParking.AddCar(client4, regularCar2);
            carParking.Display();
            Console.WriteLine("==========================Remove CAR===================================");
            //carParking.RemoveCar("SC 12345");
            carParking.Display();
            Console.ReadKey();
        }
    }
}
