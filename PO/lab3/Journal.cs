using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	public class Journal : Item
	{
		public int Number { get; set; }
		public Journal()
			: base()
		{
			Number = 0;
		}
		public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
			: base(title, id, publisher, dateOfIssue)
		{
			Number = number;
		}
		public override string ToString()
		{
			return base.ToString();
		}
		public override string GenerateBarCode()
		{
			return $"BARCODE_JOURNAL_{_id}_{Number}";
		}
	}
}
