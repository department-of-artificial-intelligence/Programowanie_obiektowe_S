namespace Lab3
{
    public class Author: Book
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public Author()
        {
            FirstName = "nieznany";
            LastName = "nieznany";
            Nationality = "nieznana";
        }

        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"Author | {base.ToString()}, firstName = {FirstName}, lastName = {LastName}, nationality = {Nationality}";
        }
    }
}
