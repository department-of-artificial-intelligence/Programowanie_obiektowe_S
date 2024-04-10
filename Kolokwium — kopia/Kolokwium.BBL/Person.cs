namespace Kolokwium.BBL
{
    public abstract class Person : IInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public override string ToString()
        {
            return $"{FirstName}; {LastName}";
        }
        public void Display()
        {
            Console.WriteLine(ToString());
        }
    }
}
