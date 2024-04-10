namespace Kolokwium.BBL
{
    internal abstract class Person
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

            return $"FirstName {FirstName}, LastName {LastName}";

        }

        public void Display()
        {

            Console.WriteLine(ToString());

        }
    }
}
