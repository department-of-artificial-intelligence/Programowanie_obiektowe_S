using System;
using System.Collections.Generic;

public abstract class Item
{
    protected int _id;
    protected string _title;
    protected string _publisher;
    protected DateTime _dateOfIssue;

    public int Id { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public DateTime DateOfIssue { get; set; }
    
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
        return $"id:{_id} title:{_title} publisher:{_publisher} date_of_issue:{_dateOfIssue}";
    }

    public void Details ()
    {
        System.Console.WriteLine(ToString());
    }
    public abstract string GenerateBarCode();
}

public class Catalog
{
    public IList<Item> Items { get; set; }
    public string ThematicDepartment { get; set; }
    public Catalog(IList<Item> items)
    {
        Items = items;
    }
    public Catalog(string thematicDepartment, IList<Item> items)
    {
        ThematicDepartment = thematicDepartment;
        Items = items;
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public override string ToString()
    {
        string s = "";
        foreach (Item item in Items) 
        {
            s += item.ToString() + "\n";
        }
        return s;
    }

    public void ShowAllItems() 
    {
        foreach(Item item in Items)
        {
            item.Details();
        }
    }
}

public class Journal : Item
{
    public int Number { get; set; }
    public Journal() 
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
        return $"{base.ToString()} number:{Number}";
    }

    public override string GenerateBarCode()
    {
        Random generator = new Random();
        string r = generator.Next(0, 1000000).ToString("D6");
        return r;
    }
}

public class Book : Item
{
    public int PageCount { get; set; }
    public IList<Author> Authors { get; set; }
    public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
        : base (title, id, publisher, dateOfIssue)
    {
        PageCount = pageCount;
        Authors = authors;
    }

    public override string ToString()
    {
        string authorstr = "";
        foreach (Author author in Authors) 
        { 
            authorstr += author.ToString() + "\n";
        }
        return $"{base.ToString()} page_count:{PageCount} authors:\n{authorstr}";
    }

    public override string GenerateBarCode()
    {
        Random generator = new Random();
        string r = generator.Next(0, 1000000).ToString("D6");
        return r ;
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
        FirstName = firstName;
        LastName = lastName;
        Nationality = nationality;
    }

    public override string ToString()
    {
        return $"first_name:{FirstName} last_name:{LastName} nationality:{Nationality}";
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