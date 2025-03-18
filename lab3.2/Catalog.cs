using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
	public class Catalog
	{
		public IList Items { get; set; }
		public string ThematicDepartment { get; set; }

		public Catalog() { }
		public Catalog(string thematicDepartment)
		{
			ThematicDepartment = thematicDepartment;
			Items = new List();
		}
		public Catalog(string thematicDepartment, IList items)
		{
			ThematicDepartment = thematicDepartment;
			Items = items;
		}
		public void AddItem(Item item)
		{
			Items.Add(item);
		}
		public override string ToString()
		{
			return $"Catalog: {ThematicDepartment}, Items Count: {Items.Count}";
		}
		public void ShowAllItems()
		{
			foreach (var item in Items)
			{
				console.WriteLine(item);
			}
		}
	}
}