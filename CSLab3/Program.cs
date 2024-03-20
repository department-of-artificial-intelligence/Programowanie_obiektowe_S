using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Item
    {
        private int _id;
        private string _title;
        private string _publisher;
        private DateTime _dateOfIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateOfIssue { get { return _dateOfIssue; } set { _dateOfIssue = value; } }
        public Item()
        {
            _id = 0;
            _title = "nieznany";
            _publisher = "nieznany";
            _dateOfIssue = DateTime.MinValue;
        }
        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"Id: {_id} tytuł: {_title} wydawca: {_publisher} data wydania: {_dateOfIssue}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public virtual string GenerateBarCode()
        {
            return "Narazie nie dziala";
        }
    }
    internal class Journal : Item
    {
        public int Number { get; set; }
        public Journal()
        {

        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return base.ToString() + $"numer: {Number}";
        }
        public override string GenerateBarCode()
        {
            return "nie dziala";
        }
    }

    internal class Book : Item
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
            return base.ToString() + $"liczba stron: {PageCount} Autorzy: {Authors}";
        }
        public override string GenerateBarCode()
        {
            return $"nie dziala";
        }
    }
    internal class Author
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public Author()
        {
            FirstName = "Nieznany";
            LastName = "Nieznany";
            Nationality = "Nieznany";
        }
        public Author(string firstName, string lastName, string nationality)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"Imie: {FirstName} Nazwisko: {LastName} Narodowość {Nationality}";
        }
    }
    internal class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> m) 
        { 
            Items = m;
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
            string s = string.Empty();
            foreach (Item item in Items) { s.AddItem(item); }///////////////////
            return $"Rzeczy: {}";
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        }
    
}