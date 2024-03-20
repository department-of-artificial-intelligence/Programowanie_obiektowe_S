namespace lab3
{
    public class Author
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Nationality { get; set; }
        Author()
        {
            FirstName = "nieznane";
            LastName = "nieznane";
            Nationality = "nieznane";
        }
        Author(string? firstName, string? lastName, string? nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"First name: {FirstName}, Last name: {LastName}, Nationality: {Nationality}";
        }
    }
}
