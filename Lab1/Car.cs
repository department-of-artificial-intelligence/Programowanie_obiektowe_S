namespace Lab1
{
    public class Car
    {
        public string brand { get; set; }
        public string model { get; set; }
        public int doorCount { get; set; }
        public float engineVolume { get; set; }
        public double avgConsump { get; set; }
        public int carCount { get; set; }

        public Car()
        {
            brand = "";
            model = "";
            doorCount = 0;
            engineVolume = 0;
            avgConsump = 0;
        }

        public Car(string brand, string model, int doorCount, float engineVolume, double avgConsump, int carCount)
        {
            this.brand = brand;
            this.model = model;
            this.doorCount = doorCount;
            this.engineVolume = engineVolume;
            this.avgConsump = avgConsump;
            this.carCount = carCount;
        }
    }
}
