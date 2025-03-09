namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int _carCount;
        private string _registrationNumber;

        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }

        public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }

        public float EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
        public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }

        public string RegistrationNumber { get { return _registrationNumber; } set { _registrationNumber = value; } }

        public int CarCount { get; }

        public Car()
        {
            Brand = "nieznany";
            Model = "nieznany";
            DoorCount = 0;
            EngineVolume = 0.0f;
            AvgConsump = 0.0;
            RegistrationNumber = "nieznany";
            _carCount++;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, string registrationNumber)
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineVolume = engineVolume;
            AvgConsump = avgConsump;
            RegistrationNumber = registrationNumber;
            _carCount++;

        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
        }

        public double CalculateConsump(double roadLength)
        {
            return (AvgConsump * roadLength) / 100;
        }

        public double CalculateCost(double roadLength, double petrolCost)
        {
            return CalculateConsump(roadLength) * petrolCost;
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"Number of cars: {_carCount}");
        }


    }
}
