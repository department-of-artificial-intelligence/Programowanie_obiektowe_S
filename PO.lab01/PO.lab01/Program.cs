// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Car {
    private string _brand;
    private string _model;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsuption;
    private static int _carCount = 0;

    public string Brand {
        get { return _brand; }
        set { _brand = value; }
    }
    public string Model {
        get { return _model; }
        set { _model = value; }
    }
    public int DoorCount {
        get { return _doorCount; }
        set { _doorCount = value; }
    }
    public float EngineVolume {
        get { return _engineVolume; }
        set { _engineVolume = value; }
    }
    public double AvgConsumption {
        get { return _avgConsuption; }
        set { _avgConsuption = value; }
    }
    Car() {
        Brand = "Nieznany";
        Model = "Nieznany";
        DoorCount = 0;
        EngineVolume = 0;
        AvgConsumption = 0.0;
        _carCount += 1;
    }
    Car(string brand, string model, int doorCount, float engineVolume, double avgConsump) {
        Brand = brand;
        Model = model;
        DoorCount = doorCount;
        EngineVolume = engineVolume;
        AvgConsumption = avgConsump;
        _carCount += 1;
    }
    public double CalculateConsump(double roadLength) {
        double consump = 0.0;
        consump += (AvgConsumption * roadLength) / 100.0;
        return consump;
    }
    public double CalculateCost(double roadLength, double petrolCost) { 
        return CalculateConsump(roadLength) * petrolCost;
    }
    public override string ToString() {
        return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors:
                { _doorCount}, EngineVol: { _engineVolume}, AvgConsump:
                {_avgConsump}, RegistrationNumber: { _registrationNumber}
        ";
    }
}