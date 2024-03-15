namespace PO.lab02
{
    internal class Person
    {

        protected string _firstName = null!;
        protected string _lastName = null!;
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
            FirstName = "";
            LastName = "";
            DateOfBirth = DateTime.MinValue;
        }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Person | FirstName: {FirstName}, LastName: {LastName}, Date of birth: {DateOfBirth}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }

    }
}
