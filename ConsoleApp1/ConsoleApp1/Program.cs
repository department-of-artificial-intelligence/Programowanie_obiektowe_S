

using System;

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
        _title = "none";
        _publisher = "none";
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
        return $"Id: {_id},Title: {_title}, Publisher: {_publisher}, Dateofissues: {_dateOfIssue}.";
    }
    public void Details()
    {
        Console.WriteLine(this);
    }
    public abstract string GenerateBarCode();
    
}

public class Journal :Item
{
    public int Number
    {
        get; set;
    }
    public Journal() {
        Number= 0;
    }
    public Journal(int id, string title, string publisher, DateTime dateOfIssue,int number):base(id,title, publisher, dateOfIssue) {   
        Number = number;
    }
    public override string ToString()
    {
        return base.ToString()+$"Number: {Number}";
    }
    private static Random random = new Random();

    public override string GenerateBarCode()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int length = 13;
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }

}
public class Book : Item
{
    public int PageCount
    {
        get; set;
    }
    public IList<Author> Authors {  get; set; }
    public Book(int id, string title, string publisher, DateTime dateOfIssue,int pagecount, IList<Author> authors):base(id,title,publisher,dateOfIssue) {
        PageCount = pagecount;
        Authors = authors;
    }
    public override string ToString()
    {
        return base.ToString()+$"PageCount: {PageCount}, Author: {Authors}";
    }
    private static Random random = new Random();
    public override string GenerateBarCode()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        int length = 13;
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    public void AddAuthor(Author author)
    {

    }


}

public class Author {
    public string FirstName
    { get; set; }
    public string LastName { get; set; }
    public string Nationality { get; set; }
    public Author() {
        FirstName = "none";
        LastName = "none";
        Nationality = "none";
    }
    public Author(string firstName, string lastName, string nationality)
    {
        FirstName = firstName;
        LastName = lastName;
        Nationality = nationality;
    }
    public override string ToString()
    {
        return $"Name: {FirstName}, LastName: {LastName}, Nationality: {Nationality}";
    }

}
public class Catalog
{
    public IList<Item> Items { get; set; }
    public string ThematicDepartments {  get; set; }
    public Catalog(IList<Item> items) {
    Items = items ;
    }
}