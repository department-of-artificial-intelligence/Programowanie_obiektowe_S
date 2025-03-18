using System;
using System.Collections.Generic;

public class Book : Item {
    public int PageCount { get; set; }
    public List<Author> Authors { get; set; }

    public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, List<Author> authors)
        : base(title, id, publisher, dateOfIssue) {
        PageCount = pageCount;
        Authors = authors;
    }

    public void AddAuthor(Author author) {
        Authors.Add(author);
    }

    public override void Details() {
        Console.WriteLine($"Book: {Title}, Page Count: {PageCount}, Publisher: {Publisher}, Date of Issue: {DateOfIssue.ToShortDateString()}");
        Console.WriteLine("Authors:");
        foreach (var author in Authors) {
            Console.WriteLine($" - {author}");
        }
    }

    public override string GenerateBarCode() {
        return $"BOOK-{Id}-{PageCount}";
    }

    public override string ToString() {
        return base.ToString() + $", Page Count: {PageCount}, Authors: {string.Join(", ", Authors)}";
    }
}