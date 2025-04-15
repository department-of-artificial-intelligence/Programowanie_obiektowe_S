namespace Lab3
{
    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public Author()
        {
            FirstName = "nieznane";
            LastName = "nieznane";
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
            return  $"Author: | Imie: {FirstName}, Nazwisko: {LastName}, Narodowość: {Nationality}";
        }
    }
}
