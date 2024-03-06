using System;
using System.Runtime.InteropServices;

class Car
{ 

   private string _brand;
   private string _model;
   private int _doorCount;
   private float _engineVolume;
   private double _avgConsump;
   private int _carCount = 0;





    public string Brand {get => _brand; set => _brand = value ; }
    public string Model { get => _model; set => _model = value ; }
    public int DoorCount { get => _doorCount; set => _doorCount = value ; }
    public float EngineVolume { get => _engineVolume; set => _engineVolume = value ; }
    public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }


    public Car(string brand, string model, int doorCount, int enginierVolume, int avgConsump) { 
    
    Brand = brand;
    Model = model;
    DoorCount = doorCount;
    EngineVolume = enginierVolume;
    AvgConsump = avgConsump;
    
    
    }

    public double CalculateConsump(double Path) {

        return Path / 100 * AvgConsump;
    }

    public double CalculateCost(double Path, double price) { 
    
    return CalculateConsump(Path * price);
    
    }

}



class Program { 

    static void Main(string[] args) {


        var car1 = new Car("woltswagen", "passate", 4, 100, 100);

        Console.WriteLine(car1.CalculateConsump(100));
    }

}