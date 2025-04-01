using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book:Item
    {
        public int PageCount {  get; set; }
        public IList<Author> Authors=new List<Author>();
        public Book(string title, int id,string publisher ,DateTime dateofissue,
            int pagecount,IList<Author> authors):base(title,id,publisher,dateofissue)
        {
            PageCount = pagecount;
            Authors = authors;


        }

        public override string ToString()
        {
            string autorzy = "";
            foreach(Author author in Authors)
            {
                autorzy += author.ToString();
            }
            return $"Book: " + base.ToString() + $"PAGECOUNT: {PageCount} {autorzy} ";

        }
        public override string GenerateBarCode()
        {
            Random random = new Random();
            int liczba = random.Next(10000000, 100000000);
            return $"Book: ID: {Id} Kod: {liczba}";
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }



    }
}
