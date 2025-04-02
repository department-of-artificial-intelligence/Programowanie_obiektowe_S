using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public class Library : IItemmanagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }

        public Library(string address = "none", List<Librarian> librarians = null, List<Catalog> catalogs = null)
        {
            Address = address;
            Librarians = librarians ?? new List<Librarian>();
            Catalogs = catalogs ?? new List<Catalog>();
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
            var catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);
            if (catalog != null)
            {
                catalog.AddItem(item);
            }
        }

        public void ShowAllItems()
        {
            foreach (var catalog in Catalogs)
                catalog.ShowAllItems();
        }

        public Item FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(id);
                if (item != null) return item;
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(title);
                if (item != null) return item;
            }
            return null;
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItem(predicate);
                if (item != null) return item;
            }
            return null;
        }

        public override string ToString()
        {
            return $"address = {Address}";
        }
    }
}
