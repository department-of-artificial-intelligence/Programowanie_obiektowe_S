using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private double _engineVolume;
        private double _avgConsump;
        private static int _carCount = 0;
        private string _registrationNumber;

        public Car()
        {
            _brand = "brak";
            _model = "brak";
            _doorCount = 0;
            _engineVolume = 0.0;
            _avgConsump = 0.0;
            _carCount++;
            _registrationNumber = "brak";
        }

        public Car(string brand, string model, int doorCount, double engineConsump, double avgConsump, string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _doorCount = doorCount;
            _engineVolume = engineConsump;
            _avgConsump = avgConsump;
            _carCount++;
            _registrationNumber = registrationNumber;
        }

        public double AvgConsump
        {
            get { return _avgConsump;  }
            set { _avgConsump = value;  }
        }

        public string Brand
        {
            get { return _brand;  }
            set { _brand = value; }
        }

        public string Model
        {
            get { return _model;  }
            set { _model = value;  }
        }

        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }

        public double EngineVolume
        {
            get { return _engineVolume;  }
            set { _engineVolume = value;  }
        }

        public string RegistrationNumber
        {
            get { return _registrationNumber;  }
            set { _registrationNumber = value;  }
        }

        public double CalculateConsump(double reoadLenght)
        {
            return (_avgConsump * reoadLenght) / 100.0;
        }

        public double CalculateCost(double reoadLenght, double petrolCast)
        {
            return CalculateConsump(reoadLenght) * petrolCast;
        }

        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVolume: {_engineVolume}, AvgConsump: {_avgConsump}, RegistratioNumber: {_registrationNumber}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"CarCount: {_carCount}");
        }
    }
}
