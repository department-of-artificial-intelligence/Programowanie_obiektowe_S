namespace PO.Lab03
{
    internal class Author : Person
    {
        public string Nationality { get; set; }

        public Author() : base()
        {
            Nationality = string.Empty;
        }

        public Author(string firstName, string lastName, string nationality) : base(firstName, lastName)
        {
            Nationality = nationality;
        }

        public override string ToString()
        {
            return $"Author | FirstName: {FirstName}, LastName: {LastName}, Nationality: {Nationality}";
        }

    }
}
