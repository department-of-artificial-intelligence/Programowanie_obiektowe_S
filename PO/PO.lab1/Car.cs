namespace PO.lab1
{
    internal class Car
    {
        private string _brand = null!;
        private string _model = null!;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;

        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int DoorCount { get => _doorCount; set => _doorCount = value; }
        public float EngineVolume { get => _engineVolume; set => _engineVolume = value; }
        public double AvgConsump { get => _avgConsump; set => _avgConsump = value; }

        private static int _carCount = 0;

        public Car()
        {
            Brand = "nieznany";
            Model = "nieznany";
            DoorCount = 0;
            EngineVolume = 0;
            AvgConsump = 0;
            _carCount++;
        }

        public Car(string brand, string model, int doorCount,
                    float engineVolume, double avgConsum)
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineVolume = engineVolume;
            AvgConsump = avgConsum;
            _carCount++;
        }

        public double CalculateConsump(double roadLength)
        {
            return (AvgConsump * roadLength) / 100.0;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            return CalculateConsump(roadLength) * petrolCost;
        }

        public override string ToString()
        {
            return $"Car | Brand: {Brand}, Model: {Model}, NumOfDoors: {DoorCount}, EngineVol: {EngineVolume}, AvgConsump: {AvgConsump}";
        }

        public void Details()
        {
            this.ToString();
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"Car Count: {_carCount}");
        }
    }



}
