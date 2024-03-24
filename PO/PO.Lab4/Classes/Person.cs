namespace PO.Lab4.Classes
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person(string firstname, string lastName, DateTime dateOfBirth)
        {

            FirstName = firstname;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"Name: {FirstName}, LastName: {LastName}, DateofBirth{DateOfBirth}";
        }
    }


}
