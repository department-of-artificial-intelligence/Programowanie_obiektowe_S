

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Book : Item
    {



        public int PageCount
        {
            get; 
            set;
        }

        public IList<Author> Authors 
        {
            get;
            set;

        }
        
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors): base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            return $"Book | PageCount: {PageCount}, Autor: {Authors}";

        }

        public override string GenerateBarCode()
        {
            return "Barcode";
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }


    }
}
