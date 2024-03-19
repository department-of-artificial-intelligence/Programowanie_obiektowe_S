using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	public class Catalog
	{
		public IList<Item> Items { get; set; }
		public string? ThematicDepartment { get; set; }
		public Catalog(IList<Item> items)
		{
			Items = items;
		}
		public Catalog(string thematicDepartment, IList<Item> items)
			: this(items)
		{
			this.ThematicDepartment = thematicDepartment;
		}
		public void AddItem(Item item)
		{
			Items.Add(item);
		}
		public override string ToString()
		{
			string result = $"Catalog ThematicDepartment: {ThematicDepartment}\n";
			foreach (Item item in Items)
			{
				result += item.ToString() + "\n";
			}
			return result;
		}
		public void ShowAllItems()
		{
			Console.WriteLine(ToString());
		}
	}
}
