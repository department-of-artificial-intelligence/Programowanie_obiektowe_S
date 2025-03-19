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
        public IList<Author> Authors{ get; set; } // KOLEKCJA

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, PageCount {PageCount}, Authors: { string.Join("\n", Authors) }  "; // Join niejawnie wywołuje ToString w Authors
        }

        public override string GenerateBarCode()
        {
            return "test w booku"; //stwórz generator 9 liczb
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }
    }
}


////popracuj tu