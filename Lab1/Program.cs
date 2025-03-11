using Lab1;

Car car1 = new Car();
car1.Details();

car1.Brand = "Fiat";
car1.Model = "126p";
car1.DoorCount = 2;
car1.EngineVolume = 650;
car1.AvgConsump = 6.0;
car1.RegistrationNumber = "KR12345";
car1.Details();

Car car2 = new Car("Syrena", "105", 2, 0.8, 7.6, "WE1234");
car2.Details();

Console.WriteLine(car1);

double routeConsumption = car2.CalculateConsump(500);
Console.WriteLine($"Zużycie paliwa na trasie: {routeConsumption} l");
double routeCost = car2.CalculateCost(500, 5);
Console.WriteLine($"Koszt przejazdu: {routeCost} PLN");

Car.DisplayCarCount();