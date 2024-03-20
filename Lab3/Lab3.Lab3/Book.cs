using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Lab3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) 
            : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string GenerateBarCode()
        {
            string output = string.Empty;
            Random rng = new Random();
            for (int i = 0; i < 8; i++)
            {
                int a = rng.Next(11, 36);
                if (a <= 10) output += (char)(a + 47);
                else output += (char)(a + 86);
            }
            return output;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
