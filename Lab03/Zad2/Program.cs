using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

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

    public void Details()
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

    public Item FindItem(Expression<Func<Item, bool>> predicate)
    {
        return Items.FirstOrDefault(predicate.Compile());
    }

    public Item FindItemBy(string title)
    {
        Item r = null;
        foreach(Item item in Items)
        {
            if(item.Title == title) 
            {
                r = item;
            }
        }
        return r;
    }

    public Item FindItemBy(int id)
    {
        Item r = null;
        foreach (Item item in Items)
        {
            if (item.Id == id)
            {
                r = item;
            }
        }
        return r;
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
        foreach (Item item in Items)
        {
            item.Details();
        }
    }
}

public interface IItemManagement
{
    void ShowAllItems();
    Item FindItemBy(int id);
    Item FindItemBy(string title);
    Item FindItem(Expression<Func<Item, bool>> predicate);
}

public class Library : IItemManagement
{
    public string Address { get; set; }
    public IList<Librarian> Librarians { get; set; }
    public IList<Catalog> Catalogs { get; set; }

    public Library(string address, IList<Librarian> libraries, IList<Catalog> catalogs)
    {
        Address = address;
        Librarians = libraries;
        Catalogs = catalogs;
    }

    public void AddLibrarian(Librarian librarian)
    {
        Librarians.Add(librarian);
    }

    public void ShowAllLibrarians() 
    {
        foreach (Librarian librarian in Librarians)
        {
            if (librarian is Librarian)
            {
                Console.WriteLine(librarian);
            }
        }
    }

    public void AddCatalog(Catalog catalog) 
    {
        Catalogs.Add(catalog);
    }

    public void AddItem(Item item, string thematicDepartment)
    {
        foreach(Catalog catalog in Catalogs) 
        {
            if(catalog.ThematicDepartment == thematicDepartment)
            {
                catalog.AddItem(item);
            }
        }
    }

    public void ShowAllItems()
    {
        foreach(Catalog catalog in Catalogs)
        {
            catalog.ShowAllItems();
        }
    }

    public Item FindItemBy(int id)
    {
        Item r = null;
        foreach (Catalog catalog in Catalogs)
        {
            r = catalog.FindItemBy(id);
        }
        return r;
    }

    public Item FindItemBy(string title)
    {
        Item r = null;
        foreach (Catalog catalog in Catalogs)
        {
            r = catalog.FindItemBy(title);
        }
        return r;
    }

    public Item FindItem(Expression<Func<Item, bool>> predicate)
    {
        Item r = null;
        foreach (Catalog catalog in Catalogs) 
        {
            r = catalog.FindItem(predicate);    
        }
        return r;
    }

    public override string ToString()
    {
        return $"address:{Address}";
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
        : base(title, id, publisher, dateOfIssue)
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
        return r;
    }

    public void AddAuthor(Author author)
    {
        Authors.Add(author);
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"name:{FirstName} {LastName}";
    }

    public void Details()
    {
        Console.WriteLine(ToString());
    }
}
public class Librarian : Person
{
    public DateTime HireDate { get; set; }
    public decimal Salary { get; set; }
    public Librarian()
    {
        HireDate = DateTime.MinValue;
        Salary = 0;
    }

    public Librarian(string firstName, string lastName, DateTime hireDate, decimal salary)
        : base(firstName,lastName)
    {
        HireDate = hireDate;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{base.ToString()} hire_date:{HireDate} salary:{Salary}";
    }
}
public class Author : Person
{
    public string Nationality { get; set; }
    public Author()
    {
        Nationality = string.Empty;
    }

    public Author(string firstName, string lastName, string nationality)
        : base(firstName,lastName)
    {
        Nationality = nationality;
    }

    public override string ToString()
    {
        return $"{base.ToString()} nationality:{Nationality}";
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

        //--- find position
        string searchedValue = "Agile C#";
        Item foundedItemById = catalog.FindItem(item => item.Id == 1);
        Item foundedItemByTitle = catalog.FindItem(item => item.Title == searchedValue);
        Item foundedItemByDateRange = catalog.FindItem(item => item.DateOfIssue >= new DateTime(2014, 12, 31) &&
        item.DateOfIssue <= new DateTime(2015, 12, 31));
        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Console.WriteLine(foundedItemById);
        Console.WriteLine(foundedItemByTitle);
        Console.WriteLine(foundedItemByDateRange);
        Item foundedItemByIdOld = catalog.FindItemBy(1);
        Item foundedItemByTitleOld = catalog.FindItemBy(searchedValue);
        Console.WriteLine("Found old way");
        Console.WriteLine(foundedItemByIdOld);
        Console.WriteLine(foundedItemByTitleOld);
        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Person librarian = new Librarian("John", "Kowalsky", DateTime.Now.Date, 2000);
        Library library = new Library("Czestochowa, Armii Krajowej 36", new List<Librarian>(), new List<Catalog>());
        library.AddLibrarian((Librarian)librarian);
        library.ShowAllLibrarians();
        Catalog catalog2 = new Catalog("Novels", new List<Item>());
        library.AddCatalog(catalog2);
        library.AddCatalog(catalog);

        Item newItem = new Book("Song of Ice and Fire", 4, "Publisher", new DateTime(2011, 1, 1), 800,
        new List<Author>() { author });
        library.AddItem(newItem, "Novels");
        Console.WriteLine(library);
        Console.WriteLine("===========================All Items=======================\r\n");
        library.ShowAllItems();
        Console.WriteLine("===========================FIND BY=======================\r\n");
        var foundedById = library.FindItemBy(4);
        var foundedByTitle = library.FindItemBy(searchedValue);
        var foundedByLambda = library.FindItem(x => x.Publisher == "Springer");
        Console.WriteLine(foundedById);
        Console.WriteLine(foundedByTitle);
        Console.WriteLine(foundedByLambda);
    }
}