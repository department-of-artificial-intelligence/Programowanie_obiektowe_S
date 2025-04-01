using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book : Item
    {
        public int PageCount {  get; set; }
        public IList<Author> Authors { get; set; }

        public Book(int id, string title, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors): base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            string temp = base.ToString() + $", PageCount: {PageCount}";
            if (Authors.Count > 0) temp += ", Authors:";
            foreach(Author author in Authors)
            {
                temp += $"\n\t{author}";
            }
            return temp;
        }

        public override string GenerateBarCode()
        {
            string temp = "";
            var rand = new Random();
            for (int i = 0; i < 13; i++) temp += rand.Next(10);
            return temp;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
