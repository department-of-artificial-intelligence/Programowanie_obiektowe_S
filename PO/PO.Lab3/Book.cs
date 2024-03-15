using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace lab3_po
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, List<Author> authors)
        : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"page count: {PageCount} ";
            str += string.Join<Author>('\n', Authors);
            return str;
        }

        public override string GenerateBarCode()
        {
            var barCode = string.Empty;
            int barCodeLength = 13;
            Random random = new Random();
            for (int i = 0; i < barCodeLength; i++)
            {
                barCode += random.Next(0, 10);
            }
            return barCode;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}