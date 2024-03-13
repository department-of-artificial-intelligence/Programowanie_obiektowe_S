using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }
        public Book(int id, string title, string publisher, DateTime dateTime,
            int pageCount, IList<Author> authors) 
            : base(id, title, publisher, dateTime)
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
            var codeLength = 12;
            var rnd = new Random();
            string code = "BK";
            var min = (int)'a';
            var max = (int)'z';
            for (int i = 0; i < codeLength; i++)
            {
                code += (char)rnd.Next(min, max);
            }
            return code;
        }
    }
}
