namespace Lab02
{
    class Garage
    {
        private string _address;
        private int _capacity;
        private int _carsCount;
        private Car?[] _cars;

        public string Address { get => _address; set => _address = value; }
        public int Capacity
        {
            get => _capacity;
            set
            {
                _capacity = value;
                _cars = new Car[value];
                for (int i = 0; i < value; i++)
                {
                    _cars[i] = null;
                }
            }
        }
        public Garage()
        {
            _address = "none";
            _capacity = 0;
            _carsCount = 0;
            _cars = new Car[0];
        }
        public Garage(string address_, int capacity_)
        {
            _address = address_;
            _capacity = capacity_;
            _carsCount = 0;
            _cars = new Car[capacity_];
            for (int i = 0; i < _capacity; i++)
            {
                _cars[i] = null;
            }
        }
        public void CarIn(Car car_)
        {
            if (_carsCount < _capacity)
            {
                _cars[_carsCount] = car_;
                _carsCount++;
            }
            else
            {
                Console.WriteLine("Brak miejsca");
            }
        }
        public Car CarOut()
        {
            if (_carsCount != 0)
            {
                Car? car1 = _cars[_carsCount - 1];
                _cars[_carsCount - 1] = null;
                _carsCount--;
                car1 = car1 ?? new Car();
                return car1;
            }
            else
            {
                Console.WriteLine("Garage jest pusty");
                return new Car();
            }
        }
        public override string ToString()
        {
            string str = $"Garage | Address: {_address}, Capacity: {_capacity}, CarsCount: {_carsCount}";
            if (_carsCount > 0)
            {
                str += ",Cars:\n";
                foreach (Car? car in _cars)
                {
                    str += $"\t{car}\n";
                }
            }
            return str;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
