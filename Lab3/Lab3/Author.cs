namespace Lab3
{
    public class Author : Person
    {
        public string Nationality { get; set; }

        public Author() : base()
        {
            Nationality = "Nieznana";
        }

        public Author(string firstName, string lastName, string nationality) : base(firstName, lastName)
        {
            Nationality = nationality;
        }

        public override string ToString()
        {
            return base.ToString() + $", Narodowosc: {Nationality}";
        }
    }
}
