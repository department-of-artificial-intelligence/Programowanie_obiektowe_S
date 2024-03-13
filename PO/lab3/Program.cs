using System.Net;

public abstract class Item
{
    protected int _id;
    protected string _title;
    protected string _publisher;
    protected DateTime _dateOfIssue;

    public int Id { get =>  _id; set => _id = value; }
    public string Title { get => _title; set => _title = value; }
    public string Publisher { get => _publisher; set => _publisher = value; }
    public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

    public Item()
    {
        _id = 0;
        _title = string.Empty;
        _publisher = string.Empty;
        _dateOfIssue = DateTime.MinValue;
    }

    public Item(string title, int id, string publisher, DateTime dateOfIssue)
    {
        _title = title;
        _id = id;
        _publisher = publisher;
        _dateOfIssue = dateOfIssue;
    }

    public override string ToString()
    {
        return $"Item | Id: {_id}, Title: {_title}" +
            $", Publisher: {_publisher}, DateOfIssue: {_dateOfIssue}";
    }

    public void Details()
    {
        Console.WriteLine(this.ToString());
    }

    public abstract string GenerateBarCode();
}

public class Catalog
{
    public IList<Item> Items { get; set; }
    public string ThematicDepartment { get; set; }
    public Catalog(IList<Item> items)
    {
        this.Items = items;
    }
    public Catalog(string thematicDepartment, IList<Item> items)
        : this(items)
    {
        this.ThematicDepartment = thematicDepartment;
    }
    public void AddItem(Item item)
    {
        Items.Add(item);
    }
    public override string ToString()
    {
        return $"Catalog ThematicDepartment: {ThematicDepartment}\n";
    }
    public void ShowAllItems()
    {
        Console.WriteLine(this.ToString() + "\n");
        foreach (Item item in Items)
        {
            Console.WriteLine(item.ToString() + "\n");
        }
    }
}

public class Journal : Item
{
    public int Number {  get; set; }
    public Journal()
        : base()
    {
        Number = 0;
    }
    public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        : base(title, id, publisher, dateOfIssue)
    {
        Number = number;
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public override string GenerateBarCode()
    {

    }

}

public class Book : Item
{
    public int PageCount { get; set; }
    public IList<Author> Authors { get; set; }
    Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
        : base(title, id, publisher, dateOfIssue)
    {
        PageCount = pageCount;
        Authors = authors;
    }
    public override string ToString()
    {

    }
    public string GenerateBarCode()
    {

    }
    public void AddAuthor(Author author)
    {
        Authors.Add(author);
    }
}

public class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nationality { get; set; }
    public Author()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Nationality = string.Empty;
    }
    public Author(string firstName, string lastName, string nationality)
    {
        FirstName=firstName;
        LastName=lastName;
        Nationality=nationality;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        
    }
}