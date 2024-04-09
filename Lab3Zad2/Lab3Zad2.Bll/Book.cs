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

        public Book(int id, string title, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
            : base(id, title, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = new List<Author>(authors);
        }

        public override string ToString()
        {
            StringBuilder listBuild = new StringBuilder();
            foreach (var i in Authors)
            {
                listBuild.Append(i);
            }
            Console.WriteLine(base.ToString());
            return $"Page Count: {PageCount} Athors: {listBuild}";
        }

        public override string GenerateBarCode()
        {
            return Guid.NewGuid().ToString();
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}
