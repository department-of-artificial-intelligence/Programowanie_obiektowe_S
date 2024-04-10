namespace Kolokwium.BBL
{
    internal class Subject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Subject(string name)
        {

            Name = name;

        }

        public Subject(string name, string description)
        {
            Name = name;
            Description = description;

        }

        public override string ToString()
        {


            return $"Subject | Name {Name}, Description {Description}";

        }

        public void Display()
        {

            Console.WriteLine(ToString());

        }


    }
}
