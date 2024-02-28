public class Car {

    private string _brand;
    private string _model;
    private int _doorCount;
    private float _engineVolume;
    private double _avgConsump;
    private static int _carCount;

    public Car() //domyslany
    {
        _brand = "none";
        _model = "none";
        _doorCount = 0;
        _engineVolume = 0;
        _avgConsump = 0.0;
        _carCount++;
    }
    //parametryczny
    public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
        _carCount++;
    }
    public string Brand
    {
        get { return _brand; }
        set { _brand = value; }
    }
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public int DoorCount
    {
        get { return _doorCount; }
        set { _doorCount = value; }
    }
    public float EngineVolume 
    {
        get { return _engineVolume; }
        set { _engineVolume = value; }
    }
    public double AverageConsump 
    {
        get { return _avgConsump; }
        set { _avgConsump = value; }
    }
    public override string ToString()
    {
        return $"Brand: {_brand}, Model: {_model}, Door Count: {_doorCount}, Engine volume: {_engineVolume}, Avg Consump: {_avgConsump}";
    }
    public double CalculateConsump(double roadLength) 
    {
        return (_avgConsump * roadLength) / 100.0;
    } 

};
