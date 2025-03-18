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

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
            : base(title, id, publisher, dateOfIssue)
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
            Random rand = new Random();
            string text = "";

            for (int i = 0; i < 13; i++)
            {
                text += rand.Next(0, 10); // Generuje losową cyfrę od 0 do 9
            }
            return text;
        }

        public override string ToString()
        {
            return base.ToString() + $", Pages: {PageCount}, Authors: {string.Join(", ", Authors)}";
        }
    }
}
