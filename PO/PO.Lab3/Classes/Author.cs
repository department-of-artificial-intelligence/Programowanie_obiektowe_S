namespace PO.Lab3.Classes
{
    public class Author : Person
    {

        public string Nationality { get; set; }
        public Author()
        {

        }

        public Author(string firstName, string lastName, string nationality) : base(firstName, lastName)
        {
            Nationality = nationality;
        }

        public override string ToString()
        {
            return base.ToString() + $" Nationality: {Nationality}";
        }






    }

}

