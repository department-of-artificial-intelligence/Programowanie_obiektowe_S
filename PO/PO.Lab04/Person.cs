namespace PO.Lab04
{
    internal abstract class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


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
            return $" Firstname: {FirstName}, Lastname: {LastName}, Date of birth: {DateOfBirth}";
        }
    }
}
