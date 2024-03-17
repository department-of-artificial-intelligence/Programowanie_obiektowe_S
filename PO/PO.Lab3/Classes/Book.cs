namespace PO.Lab3.Classes
{
    public class Book : Item
    {
        public int PageCount { get; set; }

        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            foreach (Author author in Authors)
            {
                Console.WriteLine("Autors: ");
                if (author != null)
                {
                    Console.WriteLine(author.ToString());
                }
            }
            return base.ToString() + $"PageCount:{PageCount}";
        }

        public override string GenerateBarCode()
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 13)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }


    }

}

