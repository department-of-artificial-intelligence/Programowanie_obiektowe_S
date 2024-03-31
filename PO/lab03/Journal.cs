public class Journal : Item
{
    public int Number {  get; set; }
    public Journal() : base()
    {
        Number = 0;
    }
    public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue)
    {
        Number = number;
    }
    public override string ToString()
    {
        string a = base.ToString();
        a += $" | Number: {Number}";
        return a;
    }
    public override string GenerateBarCode()
    {
        Random rnd = new Random();
        return (rnd.Next(100, 999).ToString());
    }
}