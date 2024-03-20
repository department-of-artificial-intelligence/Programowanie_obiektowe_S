using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

public interface IItemManagment
{
    public void ShowAllItems();
    public Item FindItemBy(int id);
    public Item FindItemBy(string title);
    public Item FindItemBy(Expression<Func<Item,bool>> predicate);
}
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Person()
    {
        FirstName = default;
        LastName = default;
    }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"First Name: {FirstName}\nLast name: {LastName}";
    }
    public void Details()
    {
        Console.WriteLine(ToString());
    }
}

public class Librarian:Person
{
    public DateTime HireDate {  get; set; }
    public decimal Salary { get; set; }
    public Librarian():base()
    {
        Salary = 0;
        HireDate = default;
    }
    public Librarian(DateTime hireDate, decimal salary,string firstName,string lastName):base(firstName,lastName)
    {
        HireDate = hireDate;
        Salary = salary;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nHire date: {HireDate}\nSalary: {Salary}";
    }
}
public abstract class Item
{
    private int _id;
    private string _title;
    private string _publisher;
    private DateTime _dateOfIssue;
    public int Id { get { return _id; } set { _id = value; } }
    public string Title { get { return _title; } set { _title = value; } }
    public string Publisher { get { return _publisher; } set { _publisher = value; } }
    public DateTime DateofIssue { get { return _dateOfIssue; } set { _dateOfIssue = value; } }
    public Item()
    {
        _id = 0;
        _publisher = default;
        _dateOfIssue = default;
        _title = default;
    }
    public Item(int id, string title, string publisher, DateTime dateOfIssue)
    {
        Id = id;
        Title = title;
        Publisher = publisher;
        _dateOfIssue = dateOfIssue;
    }
    public override string ToString()
    {
        return $"Id: {_id}\nTitle: {_title}\nPublisher: {_publisher}\nDate of issue: {_dateOfIssue}";
    }
    public void Details()
    {
        Console.WriteLine(ToString());
    }
    public abstract string GenerateBarCode();
}

public class Book : Item
{
    public int PageCount { get; set; }
    public IList<Author> Authors { get; set; }
    public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(id, title, publisher, dateOfIssue)
    {
        PageCount = pageCount;
        Authors = authors;
    }
    public override string ToString()
    {
        string txt = base.ToString() + $"\nPage count: {PageCount}\nAuthors:";
        foreach (Author author in Authors)
        {
            txt += author.ToString();
        }
        return txt;
    }
    public override string GenerateBarCode()
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, random.Next(8, 10))
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    public void AddAuthor(Author author)
    {
        Authors.Add(author);
    }
}

public class Author:Person
{
  
    public string Nationality { get; set; }
    public Author()
    {
        FirstName = default;
        LastName = default;
        Nationality = default;
    }
    public Author(string firstName, string lastName, string nationality)
    {
        FirstName = firstName;
        LastName = lastName;
        Nationality = nationality;
    }
    public override string ToString()
    {
        return $"\nFirst name: {FirstName}\nLast name: {LastName}\nNationality: {Nationality}";
    }
}

public class Journal : Item
{
    public int Number { get; set; }
    public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(id, title, publisher, dateOfIssue)
    {
        Number = number;
    }
    public Journal()
    {
        Title = default;
        Id = 0;
        Publisher = default;
        DateofIssue = default;
        Number = 0;
    }
    public override string ToString()
    {
        return base.ToString() + $"\nNumber {Number}";
    }
    public override string GenerateBarCode()
    {
        Random random = new Random();
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        return new string(Enumerable.Repeat(chars, random.Next(4, 6))
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

}

public class Catalog
{
    public IList<Item> Items { get; set; }
    public string ThematicDepartment { get; set; }
    public Catalog(IList<Item> items)
    {
        Items = items;
        ThematicDepartment = "Default";
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

        string txt = $"Thematic department: {ThematicDepartment}\n----Items:";
        foreach (Item item in Items)
        {
            txt += item.ToString() + "\n";
        }
        return txt;
    }
    public void ShowAllItems()
    {
        foreach (Item item in Items)
        {
            Console.WriteLine(item);
        }
    }
}
namespace PO.Lab1
{
    internal class Program
    {
        static void Main(string[] args)
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
}
