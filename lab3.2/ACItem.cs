using System;
using System.Collections.Generic;
using System.Linq;
namespace Library
{
	public abstract class Item
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Publisher { get; set; }
		public DateTime DateOfIssue { get; set; }

		protected Item() { }

		protected Item(string title, int id, string publisher, DateTime dateOfIssue)
		{
			Title = title;
			Id = id;
			Publisher = publisher;
			DateOfIssue = dateOfIssue;
		}

		public override string ToString()
		{
			return $"{Title}, {Publisher}, {DateOfIssue.ToShortDateString()}";
		}

		public abstract string GenerateBarCode();
		
	}
}

