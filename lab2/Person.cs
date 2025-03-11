namespace lab2
{
    internal class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }

        }

        public Person()
        {
            _firstName = "brak";
            _lastName = "brak";
            DateOfBirth = new DateTime(1990, 1, 1, 1, 1, 1);

        }

        public Person(string firstname, string lastname, DateTime dateOfBirth)
        {
            FirstName = firstname;
            LastName = lastname;
            DateOfBirth = dateOfBirth;

        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, DateOfBirth: {DateOfBirth}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
