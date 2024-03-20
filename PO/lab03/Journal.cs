public class Journal : Item
{
    public int Number { get; set; }

    public Journal() : base()
    {
        Number = 0;
    }

    public Journal(string title, string publisher, int id, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue)
    {
        Number = number;
    }

    public override string ToString()
    {
        string a = ToString();
        a += $", number: {Number}";
        return a;
    }

    public override string GenerateBarCode()
    {
        Random rnd = new Random();
        return (rnd.Next(100, 999).ToString());
    }
}
