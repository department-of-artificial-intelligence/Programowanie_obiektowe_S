using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }
        public Book(string titel, int id, string publisher, DateTime dateOfIssue,  int pageCount, IList<Author> authors) : base(id, titel, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }
        public override string ToString()
        {
            foreach(Author author in Authors) 
            {
                if (author != null)
                {
                    Console.WriteLine(author.ToString());
                }
            }
            return $"PageCount: {PageCount} {base.ToString()}";
        }
        public override string GenerateBarCode()
        {
            string str = string.Empty;
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(0, 78);
                str += c;
            }
            return str;
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}