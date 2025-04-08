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
            :base(title,id,publisher,dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public string ToString() => base.ToString() + $", Page Count: {PageCount}";

        public override string GenerateBarCode()
        {
            Random znak = new Random();
            char[] mozliwe = "0123456789abcdefABCDEF".ToCharArray();
            char[] kod = new char[10];
            for (int i = 0; i < 10; i++)
            {
                kod[i] = mozliwe[znak.Next(mozliwe.Length)];
            }
            string wynik = new string(kod);
            return wynik;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

    }
}
