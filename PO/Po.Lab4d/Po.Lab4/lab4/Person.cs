namespace lab4
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person()
        {
            DateOfBirth = DateTime.MinValue;
            FirstName = "nieznane";
            LastName = "nieznane";
        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}";
        }
    }
}
