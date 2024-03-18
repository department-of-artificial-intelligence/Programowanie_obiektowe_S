namespace PO.Lab01
{
    internal class Garage
    {
        private string _address;
        private int _capacity;
        private int _carsCount = 0;
        private Car[]? _cars;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

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
            _address = "nieznany";
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
                Console.WriteLine("Garaż jest pełny!");
            }
            else
            {
                if (_cars != null)
                {
                    _cars[_carsCount] = car;
                    _carsCount++;
                }
            }
        }

        public Car? CarOut()
        {
            if (_carsCount == 0)
            {
                Console.WriteLine("Garaż jest pusty!");
                return null;
            }
            else
            {
                if (_cars != null)
                {
                    Car car = _cars[_carsCount - 1];
                    _cars[_carsCount - 1] = null!;
                    _carsCount--;
                    return car;
                }
                else
                {
                    return null;
                }
            } 
        }

        public override string ToString()
        {
            string cars = "";

            if (_cars != null)
            {
                foreach (var car in _cars)
                {
                    if (car != null)
                    {
                        cars += $"\n{car}";
                    }
                }
            }
            return $"Garage | Address: {_address}, Capacity: {_capacity}, Cars count: {_carsCount}" + cars;
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}