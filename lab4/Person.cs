namespace lab4
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;

        public string FirstName
        {
            get => _firstName;
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set => _dateOfBirth = value;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, DateOfBirth: {DateOfBirth}";
        }
    }
}
