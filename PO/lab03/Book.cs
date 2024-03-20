public class Book : Item
{
    public int PageCount { get; set; }

    public IList<Author>? authors { get; set; }

    public Book()
    {

    }

    public override string GenerateBarCode()
    {
        Random rnd = new Random();
        return (rnd.Next(100, 999).ToString());
    }
}
