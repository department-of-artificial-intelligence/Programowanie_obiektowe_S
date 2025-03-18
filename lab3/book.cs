using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
	public class Book : Item
	{
		public int PageCount { get; set; }
		public IList Authors { get; set; }

		public Book() { }

		public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList authors)
		: base(title, id, publisher, dateOfIssue)
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
			return $"B-{Id}-{PageCount}";
		}

		public override string ToString()
		{
			string authors = string.Join(", ", Authors.Select(a => a.ToString()));
			return base.ToString() + $", {PageCount} pages, Authors: {authors}";
		}
	}
}