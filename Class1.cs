using System;
namespace Lab1
public class Car
{
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Details();
            car1.Brand() = "Fiat";
            car1.Model() = "126p";
            car1.DoorCount = 2;
            car1.EngineVolume = 650;
            car1.AvgConsump = 6.0;
            car1.RegistrationNumber = "KR12345";
            car1.Details();
            Car car2 = new Car("Syrena", "105", 2, 0.8f, 7.6d, "WE1234");
            
        }
    }
}

	}
}
