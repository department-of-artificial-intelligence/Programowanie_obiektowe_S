using lab1;

class Program
{
    static void Main(string[] args)
    {
        var car1 = new Car("BMW", "Slave-1", 1, 100, 100);
        Console.WriteLine(car1.CalculateConsump(100));
    }
}