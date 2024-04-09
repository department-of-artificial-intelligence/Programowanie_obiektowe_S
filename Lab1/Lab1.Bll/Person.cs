namespace Lab1.Bll
{
    public class Person
    {
        private string[]? _registrationNumbers = new string[3];

        //private Car[] _car = new Car[3];
        public int MaxCountCar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CarsCount { get; set; }
        public string Address { get; set; }
        public Person()
        {
            FirstName = "";
            LastName = "";
            Address = "";
            CarsCount++;

        }
        public Person(string firstName, string lastName, string address, Car[] car)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;

            CarsCount = car.Length;
            for (int i = 0; i < car.Length; i++)
            {
                _registrationNumbers[i] = car[i].RegistrationNumber;
            }
        }
        public void addCarRegistrationNumber(string register)
        {
            if (_registrationNumbers.Contains(register))
            {
                Console.WriteLine("istenieje rejestracji");
            }
            if (CarsCount >= 3)
            {
                Console.WriteLine("możesz mieć maksymalnie 3 samochody");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    if (i == CarsCount)
                    {
                        _registrationNumbers[i] = register;
                        CarsCount++;
                        break;
                    }
                }
            }
        }
        public void RemoveCarRegistrationNumber(string register)
        {
            if (!_registrationNumbers.Contains(register))
            {
                Console.WriteLine("nie ma takiej rejestracji");
            }
            else
            {
                for (int i = 0; i < CarsCount; i++)
                {
                    if (register == _registrationNumbers[i])
                    {
                        _registrationNumbers[i] = null;
                        //MaxCountCar--;
                        CarsCount--;
                    }

                }
            }
        }
        public override string ToString()
        {
            return "Imię: " + FirstName + ", Nazwisko: " + LastName + ", Numery rejestracyjne: " + string.Join(", ", _registrationNumbers); ;
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
