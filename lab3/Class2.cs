using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;
        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get => _title; set => _title = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Item() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Item(string title, int id, string publisher, DateTime dateOfIssue)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"Id: {_id}, Tytuł: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue} ";
        }

        public virtual void Details()
        {
            Console.WriteLine((Item)(this));
        }
        public abstract string GenerateBarCode();
    }
    class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Catalog(IList<Item> items) {
            Items = items;
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment =  thematicDepartment;
            Items = items;
        }
        public void AddItem(Item item) {
            Items.Add(item);
                }
        public override string ToString()
        {
            string b ="";
            foreach(var itemy in Items)
            {
                b+=itemy.ToString();
            }
            return $"Item: {b}, ThematicDepartment: {ThematicDepartment} ";
        }
        public void ShowAllItems() {
        foreach(var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Journal:Item
    {
        public int Number { get; set; }
        public Journal() { }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) {
            Title = title;
            Id = id;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
            Number = number;
        }
        public override string ToString()
        {
            return base.ToString()+$"Number: {Number}";
        }
        public override string GenerateBarCode() {
            return $": "+GetHashCode().ToString();
        }
    }
    class Book:Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
        {
            Title = title;
            Id = id;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
            PageCount = pageCount;
            Authors  = authors;
        }
        public override string ToString()
        {
            string a = "";
            foreach(var author in Authors)
            {
                a += author.ToString()+"\n";
            }
            return base.ToString()+ $"PageCount: {PageCount}, Authors:\n{a}";
        }
        public override string GenerateBarCode() {
        return $": " + GetHashCode().ToString();
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Author() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Author(string firstName, string lastName, string nationality) {
            FirstName = firstName;
            LastName = lastName;
            Nationality = nationality;
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName}, LastName: {LastName}, Nationality: {Nationality} ";
        }
    }
}

