namespace Lab02
{
    class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private string _registrationNumber;
        private static int _carCount = 0;
        public string Brand
        {
            get => _brand;
            set => _brand = value;
        }
        public string Model
        {
            get => _model;
            set => _model = value;
        }
        public int DoorCount
        {
            get => _doorCount;
            set => _doorCount = value;
        }
        public float EngineVolume
        {
            get => _engineVolume;
            set => _engineVolume = value;
        }
        public double AvgConsump
        {
            get => _avgConsump;
            set => _avgConsump = value;
        }
        public string RegistrationNumber
        {
            get => _registrationNumber;
            set => _registrationNumber = value;
        }
        public Car()
        {
            _brand = "none";
            _model = "none";
            _doorCount = 0;
            _engineVolume = 0.0f;
            _avgConsump = 0.0;
            _registrationNumber = "none";
            _carCount++;
        }
        public Car(string brand_, string model_, int doorCount_, float engineVolume_, double avgConsump_, string registrationNumber_)
        {
            _brand = brand_;
            _model = model_;
            _doorCount = doorCount_;
            _engineVolume = engineVolume_;
            _avgConsump = avgConsump_;
            _registrationNumber = registrationNumber_;
            _carCount++;
        }
        public double CalculateConsump(double roadLenght)
        {
            return (roadLenght * _avgConsump) / 100.0;
        }
        public double CalculateCost(double roadLenght, double petrolCost)
        {
            return CalculateConsump(roadLenght) * petrolCost;
        }
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, DoorCount: {_doorCount}, EngineVolume: {_engineVolume}, " +
            $"AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public static void DisplayCarCount()
        {
            Console.WriteLine($"Liczba samochodów: {_carCount}");
        }
    }
}
