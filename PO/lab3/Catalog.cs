using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	public class Catalog : IItemManagement
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
		public Item? FindItemBy(int id)
		{
			return Items.FirstOrDefault(item => item.Id == id);
		}
		public Item? FindItemBy(string title)
		{
			return Items.FirstOrDefault(item => item.Title == title);
		}
		public Item? FindItemBy(Expression<Func<Item, bool>> predicate)
		{
			return Items.FirstOrDefault(predicate.Compile());
		}
	}
}
