using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors): base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override string GenerateBarCode()
        {
            Random rnd = new Random();
            return rnd.Next(1000000, 9999999).ToString() + rnd.Next(100000, 999999).ToString();
        }
        public void AddAuthor(Author author) { Authors.Add(author); }
    }
}
