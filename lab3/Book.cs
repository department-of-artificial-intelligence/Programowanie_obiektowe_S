using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            string temp = base.ToString() + $", PageCount: {PageCount}";
            foreach (var author in Authors)
            {
                temp += $"\n\t{author}";
            }
            return temp;
        }

        public override string GenerateBarCode()
        {
            string res = "";
            Random rand = new Random();
            for (int i = 0; i < 13; ++i)
            {
                res += Convert.ToString(rand.Next(0, 10));
            }
            return res;
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
