namespace Lab3
{
    class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors
        { get; set; }
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }
        public override string ToString()
        {
            return $"Book | {base.ToString()}, Ilość stron: {PageCount}, autorzy: {string.Join(", ", Authors)}";
        }
        public override string GenerateBarCode()
        {
            return "1 5 8 2 1 5 8 2 1 0 4 1 9";
        }
        public void AddAuthor(Author author)
        {
                Authors.Add(author);
        }
    }
}
