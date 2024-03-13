
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

public abstract class Item
{
    protected int _id;
    protected string _title;
    protected string _publisher;
    protected DateTime _dateOfIssue;

    public int Id { get { return _id; } set { _id = value;}}
    public string Title { get { return _title; } set { _title = value; } }
    public string Publisher { get { return _publisher; } set { _publisher = value; } }
    public DateTime DateOfIssue { get { return _dateOfIssue; } set { _dateOfIssue = value; }}

    public Item()
    {
        Id = 0;
        Title = string.Empty;
        Publisher = string.Empty;
        DateOfIssue = DateTime.MinValue;
    }
    public Item(int id, string title, string publisher, DateTime dateOfIssue)
    {
        Id = id;
        Title = title;
        Publisher = publisher;
        DateOfIssue = dateOfIssue;
    }

    public override string ToString()
    {
        // return  Title + ", publisher: "+Publisher+", ID: " + Id.ToString()+ ", data: "+ DateOfIssue.ToString()
        return $"Item {Title}";
    }
    public void Details()
    {
        Console.WriteLine(this.ToString());
    }
    public abstract string GenerateBarCode();
}

public class Journal : Item
{
    public int Number { get; set; }

    public Journal() : base() { Number = 0; }
    public Journal( string title, int id, string publisher, DateTime dateOfIssue,int number) : base(id,title,publisher,dateOfIssue)
    {
        Number = number;
    }
    
    public override string ToString() {  return $"Journal {Title}"; }
    public override string GenerateBarCode()
    {
        return Title[0].ToString() + Title[1] + Publisher[0] + Publisher[1]
            + DateOfIssue.Year + DateOfIssue.Month+ DateOfIssue.Day + Number;
    }
}

public class Book : Item
{
    public int PageCount { get; set; }
    public List<Author> Authors { get; set; }
    
    public Book( string title, int id, string publisher, DateTime dateOfIssue, int pageCount, List<Author> authors) : base(id, title, publisher, dateOfIssue)
    {
        PageCount = pageCount;
        Authors = authors;
    }
    
    public override string ToString() { return $"Book {Title}"; }
    public override string GenerateBarCode()
    {
        return Title[0].ToString() + Title[1] + Publisher[0] + Publisher[1]
            + DateOfIssue.Year + DateOfIssue.Month + DateOfIssue.Day + PageCount;
    }
    public void AddAuthor(Author author) {  Authors.Add(author); }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person() { FirstName = string.Empty; LastName = string.Empty; }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
    public void Details()
    {
        Console.WriteLine(ToString() );
    }
}

public class Author : Person
{
    
    public string Nationality { get; set; }

    public Author() { FirstName = string.Empty; LastName = string.Empty; Nationality = string.Empty; }
    public Author(string firstName, string lastName, string nationality) : base(firstName,lastName)
    { 
        Nationality = nationality;
    }
    
    public override string ToString()
    {
        return $"{base.ToString} - {Nationality} author";
    }
}

public class Catalog : IItemManagement
{
    public List<Item> Items { get; set; }
    public string ThematicDepartment { get; set; }

    public Catalog() { Items = new List<Item>(); }
    public Catalog(string thematicDepartment,List<Item> items) {
        Items = items;
        ThematicDepartment = thematicDepartment;
    }
   
    public void AddItem(Item item) { Items.Add(item);}

    public Item FindItem(Expression<Func<Item, bool>> predicate )
    {
        Func<Item, bool> func = predicate.Compile();
        return Items.Find(new Predicate<Item>(func));
    }
    public Item FindItemBy(string title)
    {
        foreach (Item item in Items) { if (item.Title == title) return item;}
        return null;
    }
    public Item FindItemBy(int id)
    {
        foreach (Item item in Items) { if (item.Id == id) return item; }
        return null;
    }

    public override string ToString()
    {
        return "Catalog " + ThematicDepartment + "\n";
        
    }
    public void ShowAllItems() {
        foreach (var item in Items)
            Console.WriteLine( item.ToString());
    }
}

public interface IItemManagement
{
    public void ShowAllItems();
    public Item FindItem(Expression<Func<Item, bool>> predicate);
    public Item FindItemBy(string title);
    public Item FindItemBy(int id);
}

public class Librarian: Person
{
    public DateTime HireDate { get; set; }
    public decimal Salary { get; set; }
    public Librarian() { FirstName = string.Empty; LastName = string.Empty;HireDate = DateTime.Now; Salary = 0; } 
    public Librarian(string firstName, string lastName, DateTime HireDate, decimal Salary):base(firstName,lastName) {  this.HireDate = HireDate; this.Salary = Salary; }
    public override string ToString()
    {
        return $"Bibliotekar {base.ToString()}";
    }
}

public class Library : IItemManagement
{
    public string Address { get; set; } 
    public List<Librarian> Librarians { get; set; }
    public List<Catalog> Catalogs { get; set; }
    public Library(string address, List<Librarian> librarians, List<Catalog> catalogs) {
        Address = address ;
        Librarians = librarians ;
        Catalogs = catalogs ;
    }
    public void AddLibrarian(Librarian librarian) {Librarians.Add(librarian);}
    public void ShowAllLibrarians()
    {
        foreach (var librarian in Librarians)
            Console.WriteLine(librarian.ToString());
    }
    public void AddCatalog(Catalog catalog) {Catalogs.Add(catalog);}
    public void AddItem(Item item, string thematicDepartment)
    {
        foreach(var catalog in Catalogs)
            if ( catalog.ThematicDepartment == thematicDepartment)
                catalog.AddItem(item);
    }
    public void ShowAllItems()
    {
        foreach (var catalog in Catalogs)
            catalog.ShowAllItems();
    }
    public Item FindItemBy(int id)
    {
        Item result = null;
        foreach (var catalog in Catalogs)
        {
            result = catalog.FindItemBy(id);
            if (result != null)
                break;
        }
        return result;
    }
    public Item FindItemBy(string title)
    {
        Item result = null;
        foreach (var catalog in Catalogs)
        {
            result = catalog.FindItemBy(title);
            if (result != null)
                break;
        }
        return result;
    }
    public Item FindItem(Expression<Func<Item, bool>> predicate)
    {
        Item result = null;
        foreach (var catalog in Catalogs)
        {
            result = catalog.FindItem(predicate);
            if (result != null)
                break;
        }
        return result;
    }
}

public class Program
{
    public static int Main(string[] args)
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
        List<Item> items = new List<Item>();
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

        return 0;
    }
}