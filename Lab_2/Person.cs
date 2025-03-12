namespace Lab_2
{
    public class Person
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
            _firstName = "none";
            _lastName = "none";
            _dateOfBirth = default(DateTime);
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"FirstName:{_firstName},LastName:{_lastName},DateBirth{_dateOfBirth}";
        }
        public void Details()
        {
            Console.WriteLine(ToString());
        }
    }
}
