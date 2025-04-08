using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> author)
        {
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
            PageCount = pageCount;
            IList<Author> authorList = author;
        }

        public string ToString() => base.ToString() + $", Page Count: {PageCount}";

        public override string GenerateBarCode()
        {
            throw new NotImplementedException();
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

    }
}
