namespace Lab1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("He~llo World!");

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

}

// Ctrl shift B aby tylko skompilować bez uruchamiania
// Pierwszy commit "Lab 1 start" wybieramy commit all and sync i klikamy strzałkę w górę aby zrobić push do online
//Jak komuś sie nie udało skomitować to od instrukcji 20 w pdfie gita
//W domy okienko z tokenem wyskoczy, kopiujemy personal access token z moodla i sign in

//Nazwa funkji to adres w pamięci
//parametry to jest to co przyjmuje funkcja, argumenty to jest co jest w momencie wywołania

//Po zdaniu kolokwium plusy się liczą, plusy nic nie znaczą jeśli nie zdasz kolokwium

//Różnica między const and read only. readonly to tylko modyfikator który ustala dane pole jako tylko do odczytu, ale zapis jego może być w konstruktorze i może przechowywac typy referencyjne jak klasy. Jego wartość jest znana w runtime a nie w compilation time jak static
//Właściwośc wygląda jak pole ale zachowuje się jak metoda
//Nikt poważny po Polsku nie pisze
//Konwencje .Net, jak class to nazwa z wielkiej litery "Obiekt", pola w klasach z podłogą "_pole"
// => jak return || "get {return _area;}" to samo "get => _area"
// automatycznie w compile time "public int DoorCount{get; set;}" ale to są domyślne set i get bez naszych zmian
//W c++ jak skompilujemy pod windowsem wezmiemy execa i damy na linuksa to nie zadziała
//W c# program uruchamia się na wirtualnej maszynie .Net dzięki temu mogę tą samą binarkę przenieść między systemami (Win/Lin) i zadziała
//CIL(IL) - Common Intermediate Language --> CLR
//W C# niejawna klasa Object po której wszystkie klasy dziedziczą
//Pierwsze kolokwium UML i możliwości zaimplementowania 
//Relacje między klasami musi byc znane w nocy o północy. Agregacja, kompozycja itp.
//Zadanie stworzenie klasy Car
//ctr shift s lub file ->save all
//Git changes