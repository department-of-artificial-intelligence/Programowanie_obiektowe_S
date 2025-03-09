using System;

class Car
{
    private string _brand;
    private string _model;
    private int _doorCount;
    private double _engineVolume;
    private double _avgConsump;
    private static int _carCount = 0;

    public string Brand { get { return _brand; } set { _brand = value; } }
    public string Model { get { return _model; } set { _model = value; } }
    public int DoorCount { get { return _doorCount; } set { _doorCount = value; } }
    public double EngineVolume { get { return _engineVolume; } set { _engineVolume = value; } }
    public double AvgConsump { get { return _avgConsump; } set { _avgConsump = value; } }

    public Car()
    {
        _brand = "nieznana";
        _model = "nieznany";
        _doorCount = 0;
        _engineVolume = 0.0;
        _avgConsump = 0.0;
        _carCount++;
    }

    public Car(string brand, string model, int doorCount, double engineVolume, double avgConsump)
    {
        _brand = brand;
        _model = model;
        _doorCount = doorCount;
        _engineVolume = engineVolume;
        _avgConsump = avgConsump;
        _carCount++;
    }

    public double CalculateConsump(double roadLength)
    {
        return (_avgConsump * roadLength) / 100.0;
    }

    public double CalculateCost(double roadLength, double petrolCost)
    {
        return CalculateConsump(roadLength) * petrolCost;
    }

    public override string ToString()
    {
        return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}";
    }

    public void Details()
    {
        Console.WriteLine(this);
    }

    public static void DisplayCarCount()
    {
        Console.WriteLine($"Number of created cars: {_carCount}");
    }
}

class Garage
{
    private string _address;
    private int _capacity;
    private int _carsCount;
    private Car[] _cars;

    public string Address { get { return _address; } set { _address = value; } }
    public int Capacity
    {
        get { return _capacity; }
        set
        {
            _capacity = value;
            _cars = new Car[value];
        }
    }

    public Garage()
    {
        _address = "nieznana";
        _capacity = 0;
        _carsCount = 0;
        _cars = null;
    }

    public Garage(string address, int capacity)
    {
        _address = address;
        _capacity = capacity;
        _carsCount = 0;
        _cars = new Car[capacity];
    }

    public void CarIn(Car car)
    {
        if (_carsCount >= _capacity)
        {
            Console.WriteLine("Garage is full!");
            return;
        }
        _cars[_carsCount] = car;
        _carsCount++;
    }

    public Car CarOut()
    {
        if (_carsCount == 0)
        {
            Console.WriteLine("Garage is empty!");
            return null;
        }
        Car removedCar = _cars[_carsCount - 1];
        _cars[_carsCount - 1] = null;
        _carsCount--;
        return removedCar;
    }

    public override string ToString()
    {
        string garageInfo = $"Garage | Address: {_address}, Capacity: {_capacity}, CarsCount: {_carsCount}\n";
        foreach (Car car in _cars)
        {
            if (car != null)
                garageInfo += car.ToString() + "\n";
        }
        return garageInfo;
    }

    public void Details()
    {
        Console.WriteLine(this);
    }
}
