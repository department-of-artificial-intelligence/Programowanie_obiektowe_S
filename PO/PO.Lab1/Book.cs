using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
    internal class Book : Item
    {
        public int PageCount {  get; set; }
        public IList<Author> Authors { get; set; }
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(id,title,publisher,dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public override string GenerateBarCode()
        {
            var rand = new Random();
            string rand1 = "";
            for(int i=0;i< 1;i++)
            {
                rand1 += rand.Next().ToString();
            }
            return rand1;
        }

        public override string ToString()
        {
           
        }
    }
}
