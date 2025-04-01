using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Book : Item
    {
        public int PageCount { get; set; }

        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount,IList<Author> authoers) : 
            base (title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authoers;
        }

        public override string ToString()
        {
            string authoers = null!;
            foreach(var author in Authors)
            {
                authoers += $"Author: {author}\n" ;
            }
            return base.ToString() +
                $"Book | PageCount: {PageCount}" + authoers;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public override string GenerateBarCode()
        {
            return "BarCode\n";
        }
    }
}
