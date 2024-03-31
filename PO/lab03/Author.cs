public class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nationality { get; set; }
    public Author()
    {
        FirstName = "No name";
        LastName = "No surname";
        Nationality = "Germany";
    }
    public Author(string firstName, string lastName, string nationality) 
    {
        FirstName=firstName;
        LastName=lastName;
        Nationality=nationality;
    }
    public override string ToString() 
    {
        return $" | First Name: {FirstName} | Surname: {LastName} | Nationality: {Nationality}";
    }
}
