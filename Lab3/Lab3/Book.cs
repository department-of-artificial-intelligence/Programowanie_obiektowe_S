using System.Text;

namespace Lab3
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
            return $"Book | {base.ToString()}, pageCount = {PageCount}, authors = {Authors}";
        }
        public override string GenerateBarCode()
        {
            Random random = new Random();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < 9; i++)
            {
                char randomNumber = (char)('0' + random.Next(10));
                result.Append(randomNumber);
            }
            Console.WriteLine(result.ToString());
        }
    }
}