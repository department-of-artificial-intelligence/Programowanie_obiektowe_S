using System.Xml.Linq;

public abstract class Item {
    protected int _id;
    protected string _title;
    protected string _publisher;
    protected DateTime _dateOfIssue;

    public int Id() { return _id; }
    public string Title() { return _title; }
    public string Publisher() { return _publisher; }
    public DateTime DateOfIssue () { return _dateOfIssue; }

    public Item() { }
    public Item(int id, string title, string publisher, DateTime dateOfIssue) {
        _id = id;
        _title = title;
        _publisher = publisher;
        _dateOfIssue = dateOfIssue;
    }

    public override string ToString() {
        return $"Id: {_id}, Title: {_title}, Publisher: {_publisher}, Date of issue: {_dateOfIssue}";
    }

    public abstract string GenerateBarCode();
}

public class Journal : Item {
    private int _number;

    public int Number {
        get => _number;
        set => _number = value; 
    }

    public Journal() { }
    public Journal(int id, string title, string publisher, DateTime dateOfIssue, int number) : base(id, title, publisher, dateOfIssue) {
        _id = id;
        _title = title;
        _publisher = publisher;
        _dateOfIssue = dateOfIssue;
        _number = number;
    }
    public override string ToString() {
        return base.ToString() + $", Number: {_number}";
    }
    public override string GenerateBarCode() {
        return "journal_123";
    }
}

public class Author {
    private string _firstName;
    private string _lastName;
    private string _nationality;

    public string FirstName {
        get => _firstName;
        set => _firstName = value;
    }
    public string LastName {
        get => _lastName;
        set => _lastName = value;
    }
    public string Nationaity {
        get => _nationality;
        set => _nationality = value;
    }
    
    public Author() { }
    public Author(string firstName, string lastName, string nationality) {
        _firstName = firstName;
        _lastName = lastName;
        _nationality = nationality;
    }

    public override string ToString() {
        return $"First name: {_firstName}, Last name: {_lastName}, Nationality: {_nationality}";
    }
}

public class Book: Item {
    private int _pageCount;
    private IList<Author> _authors;

    public int PageCount {
        get => _pageCount;
        set => _pageCount = value;
    }
    public IList<Author> Authors {
        get => _authors;
        set => _authors = value;
    }

    public Book(int id, string title, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors): base(id, title, publisher, dateOfIssue) {
        _pageCount = pageCount;
        _authors = authors;
    }

    public override string ToString() {
        return base.ToString() + $", Page count: {_pageCount}, Authors: {_authors}";
    }

    public override string GenerateBarCode() {
        return "book_123";
    }

    public void AddAuthor(Author newAuthor) {
        _authors.Add(newAuthor);
    }
}

public class Catalog {
    private IList<Item> _items;
    private string _thematicDepartment;


    public IList<Item> Items {
        get => _items;
        set => _items = value;
    }
    public string ThematicDepartment {
        get => _thematicDepartment;
        set => _thematicDepartment = value;
    }

    public Catalog(IList<Item> items, string thematicDepartment) {
        IList<Item> _items = items;
        _thematicDepartment = thematicDepartment;
    }
    public void AddItem(Item newItem) {
        _items.Add(newItem);
    }
    public override string ToString() {
        return $"Thematic department: {_thematicDepartment}, Items: {_items}";
    }
    public void ShowAllItems() {
        Console.WriteLine(_items);
    }
}

Console.WriteLine("Hello, World!");
