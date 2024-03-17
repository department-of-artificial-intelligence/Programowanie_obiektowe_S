using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab3
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
            string res = "Book : " + base.ToString() + $" \\ {PageCount} :\n\t\t";
            foreach (Author author in Authors)
                res += author.ToString() + "\n\t\t";
            return res;
        }

        public override string GenerateBarCode()
        {
            string res = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(33, 126);
                res += c;
            }
            return res;
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
