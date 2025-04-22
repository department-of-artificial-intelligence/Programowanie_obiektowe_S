namespace Lab3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "Nieznane";
            LastName = "Nieznane";
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Imie: {FirstName}, Nazwisko: {LastName}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }
}
