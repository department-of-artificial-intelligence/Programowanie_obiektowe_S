using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal class Book : Item
    {

        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
        : base(title, id, publisher, dateOfIssue){ 
        
            PageCount = pageCount;
            Authors = authors;

        }

        public override string ToString()
        {
            
            StringBuilder sb = new StringBuilder();

            foreach (var authors in Authors) { 
            
                sb.Append(authors.ToString());
            
            }

            return $"Book {base.ToString()}, PageCount {PageCount}, Authors: {sb.ToString()} ";

        }

        public void AddAuthor(Author author) { 
        
            Authors.Add(author);

        }
    }
}
