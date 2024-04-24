namespace Kolokwium.BLL
{
    abstract class Person:IInfo
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public override string ToString() {
            return $"FirstName: {FirstName}, LastName: {LastName}";
        }
        public void Display()
        {
            Console.WriteLine(this);
        }
    }
}
