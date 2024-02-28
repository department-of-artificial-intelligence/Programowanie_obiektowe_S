public class Car
{
    string _brand;
    string _model;
    private static int _doorCount;
    double _engineVolume;
    double _avgConsump; //średniego spalania na 100 km

    public Car()
    {
        _brand = "none";
        _model = "model";
        _doorCount++;
        _engineVolume = 0;
        _avgConsump = 0;
    }

    public Car(string brand, string model, double engineVolume, double avgConsump)
    {
        _brand = brand;
        _model = model;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
    }

    public decimal CalculateConsump(decimal consumpValuePerSquareMeter)
    {
        return consumpValuePerSquareMeter * (decimal)_avgConsump;
    }

    public decimal CalculateCost(decimal costValue)
    {
        return costValueValue 
    }
}

