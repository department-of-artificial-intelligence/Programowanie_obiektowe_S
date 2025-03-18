using System;

public abstract class Item {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Publisher { get; set; }
    public DateTime DateOfIssue { get; set; }

    public Item() { }

    public Item(string title, int id, string publisher, DateTime dateOfIssue) {
        Title = title;
        Id = id;
        Publisher = publisher;
        DateOfIssue = dateOfIssue;
    }

    public override string ToString() {
        return $"ID: {Id}, Title: {Title}, Publisher: {Publisher}, Date of Issue: {DateOfIssue.ToShortDateString()}";
    }

    public abstract void Details();
    public abstract string GenerateBarCode();
}