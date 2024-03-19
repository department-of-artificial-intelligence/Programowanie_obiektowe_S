using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	public class Book : Item
	{
		public int PageCount { get; set; }
		public IList<Author> Authors { get; set; }
		public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors)
			: base(title, id, publisher, dateOfIssue)
		{
			PageCount = pageCount;
			Authors = authors;
		}
		public override string ToString()
		{
			string authorsString = "";
			foreach (var author in Authors)
			{
				authorsString += author.ToString() + ", ";
			}
			authorsString = authorsString.TrimEnd(',', ' ');

			return base.ToString() + $", PageCount: {PageCount}, Authors: {authorsString}";
		}
		public override string GenerateBarCode()
		{
			return $"BARCODE_BOOK_{_id}_{PageCount}";
		}

		public void AddAuthor(Author author)
		{
			Authors.Add(author);
		}
	}
}
