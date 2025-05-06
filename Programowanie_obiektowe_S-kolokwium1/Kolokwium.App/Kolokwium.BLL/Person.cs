using System.Data;

namespace Kolokwium.BLL
{
    public abstract class Person : IDisplay
    {
        public string FirstName {  get; set; }
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
            string napis = "";

            napis += $"FirstName: {FirstName} ";
            napis += $"LastName: {LastName} ";
            napis += $"DateOfBirth: {DateOfBirth} ";

            return base.ToString() + napis;
        }
        public void Display() 
        {
            Console.WriteLine(this);
        }
    }
}
