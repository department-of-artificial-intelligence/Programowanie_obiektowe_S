using Lab3;
using System.Linq.Expressions;
using System.Security.AccessControl;

namespace Lab3
{
    public abstract class Item
    {
        protected string _title;
        protected int _id;
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
            _title = "Default";
            _publisher = "Default";
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
            return $"ID: {_id}, Title: {_title}, Author: {_publisher}, Year: {_dateOfIssue}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
    }

    public class Catalog : IItemManagement
    {
        public string ThematicDepartment { get; set; }
        public IList<Item> Items { get; set; }
 

        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = string.Empty;
        }

        public Catalog(string thematicDepartments, IList<Item> items) : this(items)
        {
            ThematicDepartment = thematicDepartments;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public Item? FindItemBy(int id)
        {
            foreach (var item in Items)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public Item? FindItemBy(string title)
        {
            foreach (var item in Items)
            {
                if (item.Title == title)
                {
                    return item;
                }
            }
            return null;
        }

        public Item? FindItem(Expression<Func<Item, bool>> predicate)
        {
            Func<Item,bool> compiledFilter = predicate.Compile();
            var filteredItems = Items.Where(compiledFilter);
            return filteredItems.FirstOrDefault();
        }

        public override string ToString()
        {
            string s = $"Catalog | {ThematicDepartment} : \n ";
            foreach (Item item in Items)
            {
                s += item.ToString() + '\n';
            }
            return s;
        }

        public void ShowAllItems()
        {
            
            foreach (Item item in Items)
            {
                Console.WriteLine(this);
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
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            return "Journal | " + base.ToString() + $" Number: {Number}";
        }
        public override string GenerateBarCode()
        {
            string s = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 13; ++i)
            {
                char c = (char)random.Next(33, 126);
                s += c;
            }
            return s;
        }
    }

    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors;

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            string s = "Book | " + base.ToString() + $" Page count: {PageCount} \n";
            foreach (Author author in Authors)
            {
                s += author.ToString() + '\n';
            }
            return s;
        }

        public override string GenerateBarCode()
        {
            string s = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 13; ++i)
            {
                char c = (char)random.Next(33, 126);
                s += c;
            }
            return s;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }

    public class Author : Person
    {
        public string Nationality { get; set; }

        public Author() : base()
        {
            Nationality = string.Empty;
        }
        public Author(string firstName, string lastName, string nationality) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"Author | First Name: {FirstName}, Last Name: {LastName}, Nationality: {Nationality}";
        }
    }

    public class Library : IItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }
        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address;
            Librarians = librarians;
            Catalogs = catalogs;
        }

        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }

        public void ShowAllLibrarians()
        {
            foreach (var value in Librarians)
            {
                value.Details();
            }
        }

        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            foreach (var value in Catalogs)
            {
                if (value.ThematicDepartment == thematicDepartment)
                {
                    value.AddItem(item);
                }
            }
        }

        public void ShowAllItems()
        {
            foreach (var value in Catalogs)
            {
                value.ShowAllItems();
            }
        }

        public Item? FindItemBy(int id)
        {
            Item? i;
            foreach (var value in Catalogs)
            {
                i = value.FindItemBy(id);
                if (i != null)
                {
                    return i;
                }
            }
            return null;
        }

        public Item? FindItemBy(string title)
        {
            Item? i;
            foreach (var value in Catalogs)
            {
                i = value.FindItemBy(title);
                if (i != null)
                {
                    return i;
                }
            }
            return null;
        }

        public Item? FindItem(Expression<Func<Item, bool>> predicate)
        {
            Item? i;
            foreach (var value in Catalogs)
            {
                i = value.FindItem(predicate);
                if (i != null)
                {
                    return i;
                }
            }
            return null;
        }

        public override string ToString()
        {
            string s = new string($"Library | Address: {Address} Librarians: \n");
            foreach (var value in Librarians)
            {
                s += value.ToString() + "\n";
            }
            s += "Catalogs: \n";
            foreach (var value in Catalogs)
            {
                s += value.ToString() + "\n";
            }
            return s;
        }
    }

    public class Librarian : Person
    {
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public Librarian() : base()
        {
            HireDate = DateTime.MinValue;
            Salary = 0;
        }
        public Librarian(string firstName, string lastName, DateTime hireDate, decimal salary) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            HireDate = hireDate;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Librarian | First Name: {FirstName} Last Name: {LastName} Hire Date: {HireDate} Salary: {Salary}";
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
            return $"First Name: {FirstName} Last Name: {LastName}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
    }

    interface IItemManagement
    {
        void ShowAllItems();
        Item? FindItemBy(int id);
        Item? FindItemBy(string title);
        Item? FindItem(Expression<Func<Item,bool>> predicate);
    }
}
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
        //--- find position
        string searchedValue = "Agile C#";
        Item? foundedItemById = catalog.FindItem(item => item.Id == 1);
        Item? foundedItemByTitle = catalog.FindItem(item => item.Title == searchedValue);
        Item? foundedItemByDateRange = catalog.FindItem(item => item.DateOfIssue >= new DateTime(2014, 12, 31) &&
        item.DateOfIssue <= new DateTime(2015, 12, 31));
        Console.WriteLine("++++++++++++++++++++++++++++++++++");
        Console.WriteLine(foundedItemById);
        Console.WriteLine(foundedItemByTitle);
        Console.WriteLine(foundedItemByDateRange);
        Item? foundedItemByIdOld = catalog.FindItemBy(1);
        Item? foundedItemByTitleOld = catalog.FindItemBy(searchedValue);
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