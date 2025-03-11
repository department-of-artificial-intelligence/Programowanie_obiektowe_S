using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zad2;
Car car1 = new Car();
car1.Brand = "Fiat";
car1.Model = "126p";
car1.DoorCount = 2;
car1.EngineVolume = 650;
car1.AvgConsump = 6.0;
car1.RegistrationNumber = "KR12345";

Car car2 = new Car("Syrena", "105", 2, 0.8, 7.6, "WE1234");

// Test garaży
Garage garage1 = new Garage();
garage1.Address = "ul. Garażowa 1";
garage1.Capacity = 1;

Garage garage2 = new Garage("ul. Garażowa 2", 2);

garage1.CarIn(car1);
garage1.Details();

garage1.CarIn(car2); // Powinien wyświetlić komunikat o pełnym garażu
garage2.CarIn(car2);

var movedCar = garage1.CarOut();
garage2.CarIn(movedCar);

garage2.Details();
garage1.Details();

garage2.CarOut();
garage2.CarOut();
garage2.CarOut(); // Powinien wyświetlić komunikat o pustym garażu

Console.WriteLine("\r\n=========================================\r\n");
