public class Book : Item
{
    public int PageCount { get; set; }

    public IList<Author>? Authors { get; set; }

    public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author>authors) : base(title, id, publisher, dateOfIssue)
    {
        PageCount = pageCount;
        Authors = authors;
    }
    public override string GenerateBarCode()
    {
        Random rnd = new Random();
        return (rnd.Next(100, 999).ToString());
    }
    public void AddAuthor(Author author)
    {
        Authors.Add(author);
    }
}
