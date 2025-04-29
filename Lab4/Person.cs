namespace Lab4
{
    public abstract class Person : IContainer, IDisplayable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        public override string ToString()
        {
            return $"Person | {FirstName} {LastName}, {DateOfBirth}\n";
        }
    }
}
