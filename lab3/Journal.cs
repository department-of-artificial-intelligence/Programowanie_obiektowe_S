using System;
using System.Collections.Generic;
using System.Linq;
namespace Library
{
	public class Journal : Item
	{
		public int Number { get; set; }
		public Journal() { }
		public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title id, publisher, dateOfIssue)
		{
			Number = number;
		}
		public override string GenerateBarCode()
		{
			return $"J-{Id}-{Number}";

		}
		public override string ToString()
		{
			return base.ToString() + $",No.{Number}";
		}
	}
}