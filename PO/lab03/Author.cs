using PO.lab03;
public class Author : Person
{
    public string Nationality { get; set; }
    public Author() : base()
    {
        Nationality = "Germany";
    }
    public Author(string firstName, string lastName, string nationality) : base(firstName, lastName)
    {
        Nationality=nationality;
    }
    public override string ToString() 
    {
        string a = base.ToString();
        a += $" | Nationality: {Nationality}";
        return a;
    }
}
