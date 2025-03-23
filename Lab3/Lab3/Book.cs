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
        public override string ToString()
        {
            string authorsNames = string.Join(", ", Authors.Select(a => a.ToString()));
            return $"{base.ToString()}, Page count: {PageCount}, Authors: {authorsNames}";
        }
        public override string GenerateBarCode()
        {
            Random random = new Random();
            char[] dostepneZnaki = "0123456789".ToCharArray();
            char[] wynik = new char[9];
            for (int i = 0; i < 9; ++i)
            {
                wynik[i] = dostepneZnaki[random.Next(dostepneZnaki.Length)];
            }
            string wynikString = new string(wynik);
            return wynikString;
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}