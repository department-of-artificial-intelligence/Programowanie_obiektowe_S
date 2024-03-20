using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PO.Lab03
{
    internal class Book : Item
    {
       

        public int PageCount { get; set; }

        IList<Author> Authors { get; set; }
        public Book(int id, string title, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) 
            : base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            return $"Book | {base.ToString()}, PageCount: {PageCount}";
        }

    }
}
