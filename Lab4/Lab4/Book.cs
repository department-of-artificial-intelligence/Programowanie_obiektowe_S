using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Book : Item
    {
        public int PageCount {  get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors): base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            string temp = base.ToString() + $", PageCount: {PageCount}";
            if (Authors != null) temp += ", Authors:";
            foreach(Author author in Authors)
            {
                temp += $"\n\t{author}";
            }
            return temp;
        }

        public override string GenerateBarCode()
        {
            Random random = new Random();
            string barCode = "";

            for (int i = 0; i < 13; i++)
            {
                barCode += random.Next(0, 10).ToString();
            }

            return barCode;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
