using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Lab3
{



    public abstract class Item
    {
        public int _id { get; set; }
        public string _title { get; set; }
        public string _publisher { get; set; }
        public DateTime _dateOfIssue { get; set; }
        private static int _nextId = 1;
        public Item(string title, string publisher, DateTime dateOfIssue)
        {
            _id = _nextId++;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }

        public abstract string GenerateBarCode();
        public override string ToString()
        {
            return $"{_title} ({_publisher}, {_dateOfIssue})";
        }

    }
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal(string title, string publisher, DateTime dateOfTime, int number)
        : base(title, publisher, dateOfTime)
        {
            Number = number;
        }

        public override string GenerateBarCode()
        {
            string baseCode = $"{_id:D6}{Number:D3}{_dateOfIssue.Year % 100:D2}";
            return baseCode + Calculate(baseCode);
        }

        private int Calculate(string baseCode)
        {
            int sum = 0;
            for (int i = 0; i < baseCode.Length; i++)
            {
                int digit = baseCode[i] - '0';
                sum += (i % 2 == 0) ? digit : digit * 3;
            }
            return (10 - (sum % 10)) % 10;
        }
    }

    public class Book : Item
    {
        public int PageCount { get; set; }
        public List<Author> Authors { get; set; }
        public Book(string title, string publisher, DateTime dateOfIssue, int pageCount, List<Author> authors)
            :base(title,publisher,dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors ?? new List<Author>();
        }
        
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public override string GenerateBarCode()
        {
            string baseCode = $"{_id:D6}{PageCount:D4}{_dateOfIssue.Year % 100:D2}";
            return baseCode + Calculate(baseCode);
        }

        private int Calculate(string baseCode)
        {
            int sum = 0;
            for (int i = 0; i < baseCode.Length; i++)
            {
                int digit = baseCode[i] - '0';
                sum += (i % 2 == 0) ? digit : digit * 3;
            }
            return (10 - (sum % 10)) % 10;
        }
    }

    public class Author
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Nationality {  get; set; }

        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName} {Nationality}";
        }


    }

    public class Catalog
    {
        public string Name { get; set; }
        private List<Item> Items { get; set; }

        public Catalog(string name, List<Item> items)
        {
            Name = name;
            Items = items ?? new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }


    class Program
    {
        static void Main()
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
