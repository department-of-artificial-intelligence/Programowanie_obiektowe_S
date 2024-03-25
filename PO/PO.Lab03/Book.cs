using System.Net;

namespace PO.Lab03
{
    internal class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) 
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

            return $"{base.ToString()}, Page count: {PageCount}" + authors;
        }

        public override string GenerateBarCode()
        {
            return "87654321";
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}