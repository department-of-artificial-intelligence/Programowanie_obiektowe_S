using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab3
{
    class Book : Item
    {
        public int PageCount
        {
            get;
            set;
        }

        public IList<Author>? Authors
        {
            get;
            set;
        }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            string details = "Book: | " + base.ToString() + $" PageCount: {PageCount}, Authors:\n";
            foreach (Author i in Authors!)
            {
                details += i.ToString() + "\n";
            }
            return details;
        }

        public override string GenerateBarCode()
        {
            int charLeft = 13; //chars in Bar code
            string charNumber = Id.ToString();
            charLeft -= charNumber.Length;
            charNumber = $"{Id}"; // using var. charNumber as return
            Random random = new Random();
            for (int i = 0; i < charLeft; ++i)
                charNumber += $"{random.Next(0, 9)}";
            return charNumber;
        }

        public void AddAuthor(Author author)
        {
            Authors!.Add(author);
        }
    }
}
