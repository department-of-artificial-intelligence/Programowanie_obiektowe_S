namespace PO.lab1
{
    internal class Garage
    {
        //Pola
        private Car[]? _cars;
        private string _address = null!;
        private int _carCount = 0;
        private int _capacity;

        //Właściowści dostepowe
        public string Address { get => _address; set => _address = value; }
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                _cars = new Car[value];
            }
        }


        //Konstruktor domyślny
        public Garage()
        {
            _cars = null;
            _address = "nieznany";
            _carCount = 0;
            _capacity = 0;
        }

        //Konstruktor parapetryczny
        public Garage(string address, int capacity)
        {
            Address = address;
            Capacity = capacity;
        }

        //Funkcja wpisze auto do garazu jesli nie jest pelny
        public void CarIn(Car car)
        {
            if (Capacity == _carCount)
            {
                Console.WriteLine("Ten garaż jest już pełny!");
            }
            else
            {
                for (int i = 0; i < Capacity; i++)
                {
                    if (_cars[i] == null)
                    {
                        _cars[i] = car;
                        _carCount++;
                        break;
                    }
                }
            }
        }

        //Funkcja wypisuje ostatnie auto z garazu i je zwraca
        public Car CarOut()
        {
            if (_carCount == 0)
            {
                Console.WriteLine("Ten garaż jest pusty!");
            }
            else
            {
                for (int i = _carCount - 1; i >= 0; i--)
                {
                    if (_cars[i] != null)
                    {
                        Car car = new Car();
                        car = _cars[i];
                        _cars[i] = null;
                        _carCount--;
                        return car;
                    }
                }
            }
            return null;
        }

        public override string ToString()
        {
            string carstext = "";
            foreach (var item in _cars)
            {
                if (item != null)
                {
                    carstext += "- " + item + "\n";
                }

            }

            return $"Garage | Address: {Address}, \n" +
                $"Number of cars inside: {_carCount}, Capacity: {Capacity} Cars: \n" +
                $"{carstext}";
        }

        public void Details() { Console.WriteLine(this); }

    }


}
