using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Book : Item
    {
        public int PageCount
        {
            get; set;
        }
        public IList<Author> Authors
        {
            get; set;
        }
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int PageCount, IList<Author> authors)
        : base(id, title, publisher, dateOfIssue)
        {
            this.PageCount = PageCount;
            this.Authors = authors;
        }
        public override string ToString()
        {
            string str = " ";
            foreach (Author author in Authors)
            {
                str += author.ToString();
            }
            return base.ToString() + $"PageCount {PageCount}, Autors: {str} " + '\n';
        }
        public override string GenerateBarCode()
        {
            string str = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(0, 78);
                str += c;
            }
            return str;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
