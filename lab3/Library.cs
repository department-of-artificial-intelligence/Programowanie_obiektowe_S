using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
	class Library : IItemManagement {

		public string Address { get; set; }
		public IList<Librarian> Librarians { get; set; }
		public IList<Catalog> Catalogs { get; set; }

		public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs) {
			Address = address;
			Librarians = librarians;
			Catalogs = catalogs;
		}

		public void AddLibrarian(Librarian librarian) {
			Librarians.Add(librarian);
		}

		
		public void AddCatalog(Catalog catalog) {
			Catalogs.Add(catalog);
		}

		public void AddItem(Item item, string themathicDepartment) {
			Catalogs.FirstOrDefault(catalog => catalog.ThematicDepartment.Equals(themathicDepartment)).AddItem(item);
		}

		public Item FindItem(Expression<Func<Item, bool>> predicate) {
			return Catalogs.SelectMany(catalog => catalog.Items)
						   .FirstOrDefault(predicate.Compile());
		}

		public Item FindItemBy(int id) {
			return Catalogs.SelectMany(catalog => catalog.Items)
						   .FirstOrDefault(item => item.Id.Equals(id));
		}


		public Item FindItemBy(string title) {
			return Catalogs.SelectMany(catalog => catalog.Items)
						   .FirstOrDefault(item => item.Title.Equals(title));
		}

		public void ShowAllItems() {
			string napis = "Items:\n";

			List<Item> allItems = Catalogs.SelectMany(catalog => catalog.Items).ToList();

			foreach (Item item in allItems) {
				napis += (item + "\n");
			}

			Console.WriteLine(napis);
		}

		public void ShowAllLibrarians() {
			string napis = "Librarians:\n";

			foreach (Librarian librarian in Librarians) {
				napis += (librarian + "\n");
			}

			Console.WriteLine(napis);
		}

		public override string ToString() {
			string napis = $"Adresses: {this.Address}, ";

			napis += "Librarians:\n";

			foreach (Librarian librarian in Librarians) {
				napis += librarian + "\n";
			}

			napis += "Catalogs:\n";

			foreach (Catalog catalog in Catalogs) {
				napis += catalog + "\n";
			}

			return napis;
		}
	}
}
