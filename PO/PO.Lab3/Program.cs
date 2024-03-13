using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
namespace PO.Lab3;
public class Program
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get => _title; set { _title = value; } }
        public string Publisher { get => _publisher; set { _publisher = value; } }
        public DateTime DateOfIssue { get => _dateOfIssue; set { _dateOfIssue = value; } }
        public Item()
        {
            _id = 0;
            _title = string.Empty;
            _publisher = string.Empty;
            _dateOfIssue = DateTime.MinValue;
        }
        public Item(int id, string title, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"{_id} \\ {_title} \\ {_publisher} \\ {_dateOfIssue}";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }
        public abstract string GenerateBarCode();
    }
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal() : base()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return "Journal : "+base.ToString() + $" \\ {Number}";
        }
        public override string GenerateBarCode()
        {
            string res = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(33, 126);
                res += c;
            }
            return res;
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
            return $"{FirstName} \\ {LastName}";
        }
        public void Details()
        {
            Console.WriteLine(ToString());
        }
    }
    public class Author :Person
    {
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
            return $"Author : {FirstName} \\ {LastName} \\ {Nationality}";
        }
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
            string res = "Book : " + base.ToString() + $" \\ {PageCount} :\n\t\t";
            foreach (Author author in Authors)
                res += author.ToString() + "\n\t\t";
            return res;
        }

        public override string GenerateBarCode()
        {
            string res = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(33, 126);
                res += c;
            }
            return res;
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
    public interface IItemManagment
    {
        public void ShowAllItems();
        public Item FindItemBy(int id);
        public Item FindItemBy(string title);
        public Item FindItem(Expression<Func<Item, bool>> expression);
    }
    public class Catalog :IItemManagment
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = string.Empty;
        }
        public Catalog(string thematicDepartment, IList<Item> items) : this(items)
        {
            ThematicDepartment = thematicDepartment;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            string res = $"Catalog : {ThematicDepartment} :\n\t";
            foreach (Item item in Items)
                res += item.ToString() + "\n\t";
            return res;
        }
        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

        public Item FindItemBy(int id)
        {
            return Items.First(i => i.Id == id);
        }

        public Item FindItemBy(string title)
        {
            return Items.First(i => i.Title == title);
        }

        public Item FindItem(Expression<Func<Item, bool>> expression)
        {
            return Items.First(expression.Compile());
        }
    }
    public class Librarian :Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Librarian()
        {
            HireDate = DateTime.Now;
            Salary = 0;
        }
        public Librarian(string firstName,string lastName,DateTime hireDate, decimal salary):base(firstName,lastName)
        {
            HireDate = hireDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return "Librarian : " + base.ToString() + $" \\ {HireDate} \\ {Salary}";
        }
    }
   
    public static void Main(string[] args)
    {
        Item item1 = new Journal("JAISCR", 1, "Springer", new DateTime(2000, 1, 1), 1);
        Author author = new Author("Robert", "Cook", "Polish");
        Item item2 = new Book("Agile C#", 2, "SPRINGER", new DateTime(2015, 1, 1), 500, new List<Author>() { author });
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