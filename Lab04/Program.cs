using System.Security.Cryptography;
using System.Collections.Generic;
using System.Diagnostics;

public abstract class Item
{
   
    public int Id { get; set; }   

    

    public string Title { get; set; }

   
    public string Publisher { get; set; }

    
    public DateTime DateOfIssue { get; set; }

    public Item()
    {
        Id = 0;
        Title = "none";
        Publisher = "none";
        DateOfIssue = DateTime.MinValue;
    }

    public Item(string title, int id, string publisher, DateTime dateOfIssue)
    {
        Title = title;
        Id = id;   
        Publisher = publisher;
        DateOfIssue = dateOfIssue;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Title: {Title}, Publisher: {Publisher}, DateOfIssue: {DateOfIssue}";
    }

    public virtual void Details()
    {
        Console.WriteLine($"ID: {Id}, Title: {Title}, Publisher: {Publisher}, DateOfIssue: {DateOfIssue}");
    }

    public abstract string GenerateBarCode();
}

public class Journal : Item
{
    public int _number;
    public int Number { get { return _number; } set { _number = value; } }

    Journal(string Title, int Id, string Publisher, DateTime DateOfIssue, int number) : base(Title, Id, Publisher, DateOfIssue)
    {
        _number = number;
    }
      

    public override string GenerateBarCode()
    {
        return "Hello";
    }

    public override string ToString()
    {
        return $"ID: {Id}, Title: {Title}, Publisher: {Publisher}, DateOfIssue: {DateOfIssue}";
    }
}

public class Author
{
    public string _firstName;
    public string _lastName;
    public string _nationality;
    Author()
    {
        _firstName = "none";
        _lastName = "none";
        _nationality = "none";
    }
    public override string ToString()
    {
        return $"FirstName: {_firstName}, LastName: {_lastName}, Nationality: {_nationality}";
    }
}

public class Book : Item
{
    public int _PageCount = 0;
    public int PageCount { get { return _PageCount;} set { _PageCount = value; } }

    public IList<Author> _authors;
    
    Book(string Title, int Id, string Publisher, DateTime DateOfIssue, int PageCount, IList <Author> authors): base(Title, Id, Publisher, DateOfIssue)
    {
        _PageCount++;
        _authors = new List<Author>();
    }

    public override string GenerateBarCode() { return  "Hello"; }

    public void AddAuthor(Author author)
    {
        _authors.Add(author);
    }

}

public class Catalog
{
    public IList<Item> Items;
    private string ThematicDepartments { get; set; }

    Catalog(IList<Item> items)
    {
        Items = items;
    }
    Catalog(IList<Item> items, string thematicDepartments)
    {
        Items = items;
        ThematicDepartments = thematicDepartments;
    }

    public void AddItem(Item item) { Items.Add(item); }

    public override string ToString()
    {
        return $"{ThematicDepartments}, {Items}";
    }

    public void ShowAllItems()
    {
        Console.WriteLine(Items);
        foreach (Item item in Items)
        {
            Console.WriteLine(Items);
        }
    }

}

public class Program
{
    public static void Main()
    {
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
    }
}