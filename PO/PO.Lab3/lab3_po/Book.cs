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
        private int _pageCount;
        private List <Author> _authors = new List <Author> ();

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, List<Author>authors)
        :base(title, id, publisher, dateOfIssue)
        {
            _pageCount = pageCount;
            _authors = authors;
        }

        public override string ToString()
        {
            var str = base.ToString();
            str += $"page count: {_pageCount} ";
            str += string.Join<Author>('\n', _authors);
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
            _authors.Add(author);
        }
    }
}
