namespace Lab2
{
    class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DateOfBirth { get; set; }

        public Person()
        {
            _firstName = "";
            _lastName = "";
            _dateOfBirth = default(DateTime);
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"First name: {_firstName}, Last name: {_lastName}, Date of birth: {_dateOfBirth}\n";
        }

        public virtual void Details()
        {
            Console.WriteLine(ToString());
        }
    }
}
