namespace PO.lab04
{
    public abstract class Person
    {
        public string FirstName { get => FirstName; set => FirstName = value; }
        public string LastName { get => LastName; set => LastName = value; }
        public DateTime DateOfBirth { get => DateOfBirth; set => DateOfBirth = value; }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} | Surname: {LastName} | Birthday: {DateOfBirth}";
        }
    }
}
