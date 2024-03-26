namespace PO.Lab03
{
    internal class Book : Item
    {


        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(int id, string title, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
            : base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = new List<Author>(authors);
        }

        public override string ToString()
        {
            string str = "";
            foreach (var element in Authors)
            {
                str += $"\n{element}";
            }
            return $"Book| Title:{_title} Id:{_id} Publisher:{_publisher} DateOffIssue: {_dateOfIssue} " +
                $"PageCount: {PageCount} + Authors: {str} ";
        }

        public override string GenerateBarCode()
        {
            Random random = new Random();
            string str = "";
            for (int i = 0; i < 12; i++)
            {
                str += random.Next(10);
            }
            return str;
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

    }
}
