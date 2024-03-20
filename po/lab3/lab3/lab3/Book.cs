using System.Net;

namespace lab3
{
    internal class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }
        public Book(string title,int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Authorization> authors)
            : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }
        public override string ToString()
        {
            string authors = "";
            foreach (var author in Authors)
            {
                authors += $"\n{author}";
            }
            return $"{base.ToString()}, authors | {authors}";
        }

        public override string GenerateBarCode()
        {
            return " ";
        }

        public void AddAuthor(Author author)
        {
            author.Add(author);
        }
    }
}
