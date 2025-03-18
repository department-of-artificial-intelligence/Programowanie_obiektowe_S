using System;
using zad2;


public class Garage
{
    private string _address;
    private int _capacity;
    private int _carsCount = 0;
    private Car[] _cars;

    public string Address
    {
        get => _address;
        set => _address = value;
    }

    public int Capacity
    {
        get => _capacity;
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
        _cars = null;
    }

    public Garage(string address, int capacity)
    {
        _address = address;
        _capacity = capacity;
        _cars = new Car[capacity];
    }

    public void CarIn(Car car)
    {
        if (_carsCount >= _capacity)
        {
            Console.WriteLine("Garaż jest pełny. Nie można dodać samochodu.");
            return;
        }
        _cars[_carsCount] = car;
        _carsCount++;
    }

    public Car CarOut()
    {
        if (_carsCount <= 0)
        {
            Console.WriteLine("Garaż jest pusty.");
            return null;
        }
        _carsCount--;
        Car removedCar = _cars[_carsCount];
        _cars[_carsCount] = null;
        return removedCar;
    }

    public override string ToString()
    {
        string info = $"Adres: {_address}\nPojemność: {_capacity}\nLiczba samochodów: {_carsCount}\n";

        if (_cars != null)
        {
            info += "Samochody:\n";
            foreach (var car in _cars)
            {
                info += car != null ? $"{car}\n" : "[Wolne miejsce]\n";
            }
        }
        return info;
    }

    public void Details()
    {
        Console.WriteLine(this);
    }
}