using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Library : IItemManagment
    {
        public string? Address { get; set; }
        public IList<Librarian>? Librarians { get; set; }
        public IList<Catalog>? Catalogs { get; set; }

        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address;
            Librarians = librarians;
            Catalogs = catalogs;
        }

        public void AddLibrarian(Librarian librarian)
        {
            Librarians?.Add(librarian);
        }

        public void ShowAllLibrarians()
        {
            if (Librarians != null)
                foreach (var librarian in Librarians)
                    librarian.Details();
		}

        public void AddCatalog(Catalog catalog)
        {
            Catalogs?.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            var catalog = Catalogs?.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);
            catalog?.AddItem(item);
            
        }

        public void ShowAllItems() 
        {
            if (Catalogs != null)
                foreach (var catalog in Catalogs) 
                {
					Console.WriteLine("All items from catalog: \n");
					catalog.ShowAllItems();
				}
		}

        public Item FindItemBy(int id)
        {
			if (Catalogs != null)
				foreach (var catalog in Catalogs)
					if(catalog.Items != null)
						foreach (var item in catalog.Items) 
                            if (item.Id == id)
                                return item;
            return null;
		}

		public Item FindItemBy(string title)
		{
			if (Catalogs != null)
				foreach (var catalog in Catalogs)
					if (catalog.Items != null)
						foreach (var item in catalog.Items)
							if (item.Title == title)
								return item;
			return null;
		}

        public Item FindItem(Expression<Func<Item, bool>> predicate) 
        {
            if (Catalogs != null)
                foreach (var catalog in Catalogs)
                    if (catalog.Items != null)
                    {
                        var item = catalog.Items.AsQueryable().FirstOrDefault(predicate);
                        if (item != null)
                            return item;
                    }
            return null;
		}

		public override string ToString()
		{
            string catalogs = "", librarians = "";
            if (Catalogs != null)
                foreach (var catalog in Catalogs)
                    catalogs += catalog.ToString();
            if (Librarians != null)
                foreach (var librarian in Librarians)
                    librarians += librarian.ToString();
			return $"Address: {Address}\nAll catalogs:\n {catalogs}\nAll librarians:\n {librarians}";
		}
	}
}
