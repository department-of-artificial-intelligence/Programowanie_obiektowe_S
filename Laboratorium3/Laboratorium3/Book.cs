using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book( string title , int id , string publisher, DateTime dateOfIssue,
            int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, page count: {PageCount}, authors: {Authors.Count}";
        }


        public override string GenerateBarCode()
        {
            //losowa generacja kodu kreskowego
            Random random = new Random();
            string res = "";

            for (int i = 0; i < 13; i++)
            {
                res += random.Next(1, 10);
            }
            return res;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
