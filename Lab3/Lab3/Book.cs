using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = new List<Author>(authors);
        }
        public override string ToString()
        {
            string napis = base.ToString();
            napis += $" Page Count:{this.PageCount}, " + $"Authors:\n";
            foreach (Author author in this.Authors)
            {
                napis += author + "\n";
            }
            return napis;
        }
        public override string GenerateBarCode()
        {
            string tmp = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                tmp += random.Next(0, 10).ToString();
            }
            return tmp;
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
