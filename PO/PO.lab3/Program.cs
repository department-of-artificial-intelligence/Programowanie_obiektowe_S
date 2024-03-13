using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
namespace PO.lab3;

class Program
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

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
            set { _dateOfIssue = value; }
        }
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
            return $"id: {_id}, title: {_title}, publisher: {_publisher}, dateOfIssue: {_dateOfIssue} " + '\n';
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public abstract string GenerateBarCode();
    }
    public class Journal : Item
    {
        public int Number
        {
            get; set;
        }
        public Journal() { }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        :base(id,title,publisher,dateOfIssue) 
        {
            Number = number;
        }
        public override string GenerateBarCode()
        {
            string str = "";
            Random random = new Random();
            for(int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(0,78);
                str += c;
            }
            return str;
        }


    }
    public class Author
    {
        public string FirstName
        {
            get; set;
        }
        public string LastName
        {
            get; set;
        }
        public string Nationality
        {
            get; set;
        }
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
            return $"FirstName: {FirstName},LastName: {LastName},Nationality: {Nationality} ";
        }
    }


    public class Book: Item
    {
        public int PageCount
        {
            get;set;
        }
        public IList<Author> Authors
        {
            get;set;
        }
        public Book(string title, int id,string publisher,DateTime dateOfIssue,int PageCount, IList<Author> authors)
        :base(id, title, publisher, dateOfIssue)
        {
            this.PageCount = PageCount;
            this.Authors = authors;
        }
        public override string ToString()
        {
            string str = " ";
            foreach (Author author in Authors)
            {
                str += author.ToString();
            }
            return base.ToString() + $"PageCount {PageCount}, Autors: {str} " + '\n';
        }
        public override string GenerateBarCode()
        {
            string str = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(0, 78);
                str += c;
            }
            return str;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
    public class Catalog
    {
        public IList<Item> Items
        {
            get;set;
        } 
        public string ThematicDepartment
        {
            get;set;
        }
        public Catalog(IList<Item> items)
        {
            this.Items = items;
            ThematicDepartment = string.Empty;
        }
        public Catalog(string thematicDepartmemt, IList<Item> items) 
        {
            this.Items = items;
            ThematicDepartment = thematicDepartmemt;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            string str = "";
            foreach(Item item in Items)
            {
                str += item.ToString();
            }
            return $"ThematicDepartment: {ThematicDepartment}, Items: {str} ";
        }
        public void ShowAllItems()
        {
            Console.WriteLine(ToString());
        }
    }



    public static void Main(string[] args)
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
