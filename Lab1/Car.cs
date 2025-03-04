namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private float _engineVolume;
        private double _avgConsump;
        private static int carCount;

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


    }
}
