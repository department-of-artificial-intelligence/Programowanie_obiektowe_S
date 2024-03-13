using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable CS8618

namespace PO
{
    class Programm3
    {
        abstract class Item
        {
            protected int _id;
            protected string _title;
            protected string _publisher;
            protected DateTime _dateOfIssue;

            public int Id { get => _id; set { _id = value; } }
            public string Title { get => _title;  set { _title = value; } }
            public string Publisher { get => _publisher; set { _publisher = value; } }
            public DateTime DateOfIssue { get => _dateOfIssue; set { _dateOfIssue = value; } }

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
                return $"{Id}, {Title}, {Publisher}, {DateOfIssue}";
            }
            public void Details()
            {
                Console.WriteLine(this);
            }
            public abstract string GenerateBarCode();
        }
        class Journal : Item
        {
            public int Number { get; set; }
            public Journal() : base()
            {
                Number = 0;
            }
            public Journal(string ttl, int id, string publish, DateTime DOU, int num) : base(id, ttl, publish, DOU) 
            { 
                Number = num;
            }
            public override string ToString()
            {
                return $"{base.ToString()}, Number: {Number}";
            }

            public override string GenerateBarCode()
            {
                string str = "";
                Random random = new Random();
                for (int i = 0; i < 13; i++)
                {
                    char c = (char)random.Next(0,78);
                    str += c;
                }
                return str;
            }
        }
        class Author
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
                return $"Author : {FirstName} | {LastName} | {Nationality}";
            }
        }
        class Book : Item
        {
            public int PageCount { get; set; }
            public List<Author> Authors { get; set; }

            public Book(string ttl, int id, string publish, DateTime DOU, int pageCount, List<Author> authors) : base(id, ttl, publish, DOU)
            {
                PageCount = pageCount;
                Authors = authors;
            }
            public override string ToString()
            {
                return $"Book: Authors - {Authors}, Page Count - {PageCount}, {base.ToString()}, {GenerateBarCode()}";
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
            public void AddAuthor(Author au)
            {
                Authors.Add(au);
            }
        }
        class Catalog
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
                return $" Dep: {ThematicDepartment}, with items: ";
            }
            public void ShowAllItems()
            {
                Console.WriteLine(this.ToString());
                foreach (Item item in Items)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

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