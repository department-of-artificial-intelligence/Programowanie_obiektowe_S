using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
	public class Library : IItemManagement
	{
		public string? Address { get; set; }
		public IList<Librarian> Librarians { get; set; }
		public IList<Catalog> Catalogs { get; set; }
		public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
		{
			Address = address;
			Librarians = librarians;
			Catalogs = catalogs;
		}
		public void AddLibrarian(Librarian librarian)
		{
			Librarians.Add(librarian);
		}
		public void ShowAllLibrarians()
		{
			foreach (var librarian in Librarians)
			{
				Console.WriteLine(librarian.ToString());
			}
		}
		public void AddCatalog(Catalog catalog)
		{
			Catalogs.Add(catalog);
		}
		public void AddItem(Item item, string thematicDepartment)
		{
			Catalog? catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);

			if (catalog == null)
			{
				catalog = new Catalog(thematicDepartment, new List<Item>());
				Catalogs.Add(catalog);
			}

			catalog.AddItem(item);
		}
		public void ShowAllItems()
		{
			foreach (var catalog in Catalogs)
			{
				catalog.ShowAllItems();
			}
		}
		public Item? FindItemBy(int id)
		{
			foreach (var catalog in Catalogs)
			{
				Item? item = catalog.FindItemBy(id);
				if (item != null)
				{
					return item;
				}
			}
			return null;
		}
		public Item? FindItemBy(string title)
		{
			foreach (var catalog in Catalogs)
			{
				Item? item = catalog.FindItemBy(title);
				if (item != null)
				{
					return item;
				}
			}
			return null;
		}
		public Item? FindItemBy(Expression<Func<Item, bool>> predicate)
		{
			foreach (var catalog in Catalogs)
			{
				Item? item = catalog.FindItemBy(predicate);
				if (item != null)
				{
					return item;
				}
			}
			return null;
		}
		public override string ToString()
		{
			return $"Library Address: {Address}\nNumber of Librarians: {Librarians.Count}\nNumber of Catalogs: {Catalogs.Count}";
		}
	}
}
