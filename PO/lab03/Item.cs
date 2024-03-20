public abstract class Item
{
    protected int _id;
    protected string _title = null!;
    protected string _publisher = null!;
    protected DateTime _dateOfIssue;

    protected int Id { get => _id; set => _id = value; }
    protected string Title { get => _title; set => _title = value; }
    protected string Publisher { get => _publisher; set => _publisher = value; }
    protected DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

    public Item()
    {
        _id = 0;
        _title = "brak tytułu";
        _publisher = "brak wydawcy";
        _dateOfIssue = new DateTime();
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
        return $"Title: {_title}, id: {_id}, publisher: {_publisher}, date of issue: {_dateOfIssue}";
    }

    public virtual void Details()
    {
        Console.WriteLine(this.ToString());
    }

    public abstract string GenerateBarCode();
}