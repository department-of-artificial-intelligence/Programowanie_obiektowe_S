using System;

public class Journal : Item {
    public int Number { get; set; }

    public Journal() { }

    public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        : base(title, id, publisher, dateOfIssue) {
        Number = number;
    }

    public override void Details() {
        Console.WriteLine($"Journal: {Title}, Number: {Number}, Publisher: {Publisher}, Date of Issue: {DateOfIssue.ToShortDateString()}");
    }

    public override string GenerateBarCode() {
        return $"JOURNAL-{Id}-{Number}";
    }

    public override string ToString() {
        return base.ToString() + $", Number: {Number}";
    }
}