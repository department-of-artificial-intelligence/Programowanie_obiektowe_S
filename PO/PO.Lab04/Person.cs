namespace PO.Lab04
{
    internal abstract class Person
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
            return $"Person | First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth}";
        }
    }
}
