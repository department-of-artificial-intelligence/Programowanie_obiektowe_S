using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Bll
{
    public class Book:Item
    {
        public int PageCount { get; set; }
        public List<Author> Authors { get; set; }
        public Book(string title, int id, string publisher, DateTime date, int pagecount, List<Author> authors)
        : base(title, id, publisher, date)
        {
            PageCount = pagecount;
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
            for (int i = 0; i < 8; i++)
            {
                rand1 += rand.Next().ToString();
            }
            return rand1;
        }
        public override string ToString()
        {
            string tmp = base.ToString() + $", Author: {Authors.Select(a=>a.ToString())} ";
            return tmp;
        }
    }
}
