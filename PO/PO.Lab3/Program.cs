class Catalog
{
    public IList<Item> Items { get; set; }
    public string ThematicDepartment { get; set; }
    public Catalog(IList <item> items)
    {

    }
    public Catalog(string thematicDepartment, IList<Item> items)
    {

    }
    public void AddItem(Item item)
    {

    }
    public override string ToString()
    {
        return base.ToString();
    }
}

class Author
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Nationality { get; set; }
    Author()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Nationality = string.Empty;
    }
    Author(string firstName, string lastName, string nationality)
    {
        FirstName += firstName;
        LastName += lastName;
        Nationality += nationality;
    }
    public override string ToString()
    {
        return $"{FirstName} | {LastName} | {Nationality}";
    }
}

class Journal
{
    public int Number { get; set; }
    Journal() { }
    Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
    {
    }
    public override string ToString()
    {
        return $"{Number}{Journal}";
    }
}

class Book
{
    public int PageCount { get; set; }
    public IList<Author> Authors { get; set; }
    public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author)
    {

    }
    public string ToString()
    {

    }
    public string GenerateBarCode()
    {

    }
    public void AddAuthor(Author author)
    {

    }
}

abstract class Item
{
    protected int _id;
    protected string _title;
    protected string _publisher;
    protected string _dateOfIssue;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }
    public string Publisher
    {
        get { return _publisher; }
        set { _publisher = value; }
    }
    public DateTime DateOfIssue
    {
        get { return _dateOfIssue; }
        set { _dateOfIssue = value }
    }
    public Item()
    {
        Id = 0;
        Title = string.Empty;
        Publisher = string.Empty;
        DateOfIssue = DateTime.Now;
    }
    public Item(string title, int id, string publisher, DateTime dateOfIssue)
    {
        Id = id;
        Title = title;
        Publisher = publisher;
        DateOfIssue = dateOfIssue;
    }
    public string ToString()
    {
        return $"{Id} {Title} {Publisher} {DateOfIssue} {Item}"
    }
    public void Details()
    {

    }
    public string GenerateBarCode()
    {
        Random generator = new Random();
        String r = generator.Next(0, 999999).ToString("D13");
        return r;
    }
}


Item item1 = new Journal("JAISCR", 1, "Springer", new DateTime(2000, 1, 1), 1);
Author author = new Author("Robert", "Cook", "Polish");
Item item2 = new Book("Agile C#", 2, "SPRINGER", new DateTime(2015, 1, 1), 500,
new List<Author>() { author });
((Book)item2).AddAuthor(author);
var bookBarCode = ((Book)item2).GenerateBarCode();
var journalBarCode = ((Journal)item1).GenerateBarCode();
Console.WriteLine($"{item1} \r\n Barcode {journalBarCode}");
Console.WriteLine($"{item2} \r\n Barcode {bookBarCode}");
IList<Item> items = new List<Item>();
items.Add(item1);
items.Add(item2);
Catalog catalog = new Catalog("IT C# development", items);
catalog.AddItem(new Journal("Neurocomputing", 1, "IEEE", new DateTime(2020, 1, 1), 1));
Console.WriteLine(catalog);
catalog.ShowAllItems();