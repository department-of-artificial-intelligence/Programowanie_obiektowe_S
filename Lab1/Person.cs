namespace Lab02
{
    class Person
    {
        private int _carsCount;
        private string?[] _registrationNumbers;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount
        {
            get => _carsCount;
            set
            {
                if (_carsCount <= 3)
                {
                    _carsCount = value;
                }
            }
        }
        public Person()
        {
            FirstName = "none";
            LastName = "none";
            Address = "none";
            _carsCount = 0;
            _registrationNumbers = new string?[3] { null, null, null };
        }
        public Person(string firstName, string lastName, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            _registrationNumbers = new string?[3] { null, null, null };
        }
        public Person(string firstName, string lastName, string address, Car[] cars)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            if (cars.Length <= 3)
            {
                _carsCount = cars.Length;
            }
            else
            {
                Console.WriteLine("Max count of car is 3");
                _carsCount = 3;
            }
            _registrationNumbers = new string?[3] { null, null, null };
            for (int i = 0; i < _carsCount; i++)
            {
                _registrationNumbers[i] = cars[i].RegistrationNumber;
            }
        }
        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (_carsCount < 3)
            {
                _registrationNumbers[_carsCount] = registrationNumber;
                _carsCount++;
            }
            else
            {
                Console.WriteLine("Osaba już ma 3 samochody");
            }
        }
        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            bool isCar = true;
            for (int i = 0; i < 3; i++)
            {
                if (_registrationNumbers[i] == registrationNumber)
                {
                    _registrationNumbers[i] = null;
                    _carsCount--;
                    isCar = false;
                }
            }
            if (isCar)
            {
                Console.WriteLine("Nie ma samochodu z podanym numerem");
            }
        }
        public override string ToString()
        {
            string str = $"Person | FirstName: {FirstName}, LastName: {LastName}, Address: {Address}, CarsCount: {_carsCount}";
            if (_carsCount > 0)
            {
                str += ", RegistrationNumbers:\n ";
                foreach (string? registrationNumbers in _registrationNumbers)
                {
                    if (registrationNumbers != null)
                    {
                        str += $"\t Car with registration number: {registrationNumbers}\n";
                    }
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
