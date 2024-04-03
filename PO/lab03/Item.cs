using System.Data;
using System.Security.Cryptography.X509Certificates;

public abstract class Item
{
    protected int _id;
    protected string _title = null!;
    protected string _publisher = null!;
    protected DateTime _dateOfIssue;

    public int Id { get => _id; set => _id = value; }
    public string Title { get => _title; set => _title = value; }
    public string Publisher { get => _publisher; set => _publisher = value; }
    public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }
    public Item()
    {
        _id = 0;
        _title = "No title";
        _publisher = "No publisher";
        _dateOfIssue = new DateTime();
    }
    public Item(string title, int id, string publisher, DateTime dateOfIssue)
    {
        Id = id;
        Title = title;
        Publisher = publisher;
        DateOfIssue = dateOfIssue;
    }
    public override string ToString()
    {
        return $"Number ID: {_id} | Title: {_title} | Publisher: {_publisher} | Date of issue: {_dateOfIssue}";
    }
    public void Details() 
    {
        Console.WriteLine(this.ToString());
    }
    public abstract string GenerateBarCode();
}