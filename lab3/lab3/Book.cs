using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Book : Item
    {
        private IList<Author> _authors;
        public int PageCount { get; set; }
        public IList<Author> Authors
        {
            get => _authors;
            set => _authors = value ?? new List<Author>();
        }
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
            : base(title, id, publisher, dateOfIssue)
        {
            PageCount = pageCount;
            Authors = authors;
        }
        public override string ToString()
        {
            string sBook = $"Book: " + base.ToString() + $", {PageCount}, {Authors.Count} ";
            foreach (var a in Authors)
            {
                sBook += $"\n {a.ToString()}";
            }
            return sBook;
        }
        public override string GenerateBarCode()
        {
            var rand = new Random();
            char[] wylosowane = new char[13];
            char[] znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_-+=<>?".ToCharArray();
            for (var i = 0; i < 13; ++i)
            {
                wylosowane[i] += znaki[rand.Next(znaki.Length)];
            }
            string kod = new(wylosowane);
            return kod;
        }
        public void AddAuthor(Author author)
        {
            if (author == null)
            {
                throw new ArgumentNullException(nameof(author));
            }
            if (!_authors.Contains(author))
            {
                _authors.Add(author);
            }
        }
    }
}
