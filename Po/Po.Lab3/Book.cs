using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Po.Lab3
{
    internal class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author> Authors{ get; set; }
        public Book(string title, int id,string publisher, 
            DateTime dateOfIssue,int pageCount, IList<Author>e): 
            base(title,id,publisher,dateOfIssue){ 
            
            PageCount = pageCount;
            Authors = e != null ? new List<Author>(e) : new List<Author>();
        }

        public override string ToString()
        {
            string authorNames = string.Join(", ", Authors.Select(a => a.ToString()));

            return base.ToString() + $"Authors: {authorNames}";
        }
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
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
    }
}
