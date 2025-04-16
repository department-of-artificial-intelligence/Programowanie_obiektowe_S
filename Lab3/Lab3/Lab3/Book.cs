using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Book : Item
    {
        public int PageCount { get; set; }
        public IList<Author>? Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue)
		{
            PageCount = pageCount;
            Authors = authors;
        }

		public override string ToString()
		{
            string authors = "";
			if (Authors != null)
			    foreach (var author in Authors)
                    authors += author.ToString();
			return $"Book page count: {PageCount}\nAuthors of book:\n {authors}" + base.ToString();
		}

		public override string GenerateBarCode()
		{
			return "BBC";
		}

        public void AddAuthor(Author author)
        {
            Authors?.Add(author);
        }
	}
}
