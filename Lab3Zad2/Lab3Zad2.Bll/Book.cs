using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Zad2.Bll
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }
        public Book(string title, int id, string publiser, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, publiser, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
            _id = id;
        }
        public override string ToString()
        {
            string Aut = string.Empty;
            Aut += string.Join("\n", Authors);
            return base.ToString() + $" Id:{_id} Autor: {Aut} Ilosc stron: {PageCount}";
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
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }


    }
}
