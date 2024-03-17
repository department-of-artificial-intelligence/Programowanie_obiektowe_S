namespace PO.Lab3.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {FirstName}, LastName: {LastName}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }

}

