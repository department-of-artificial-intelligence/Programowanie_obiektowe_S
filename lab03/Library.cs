using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Library:IItemMenagment
    {
        public string Address { get; set; }

        public IList<Librarian> Librarians { get; set; }
   
        public IList<Catalog> Catalogs { get; set; }

        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs){
            Address = address;
            Librarians = librarians;
            Catalogs=catalogs;
        }

        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }

        public void ShowAllLibrarians() {
            if (Librarians.Count == 0)
            {
                Console.WriteLine("BRAK");
                return;
            }

            foreach (var librarian in Librarians)
            {
                Console.WriteLine(librarian.ToString());
            }
        }

        public void AddCatalog(Catalog catalog) { 
        Catalogs.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            var catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);

            if (catalog == null)
            {
                catalog = new Catalog(thematicDepartment, new List<Item>());
                Catalogs.Add(catalog);
            }

            catalog.AddItem(item);
        }

        public void ShowAllItems()
        {
            if (Catalogs.Count == 0)
            {
                Console.WriteLine("BRAK");
                return;
            }

            foreach (var catalog in Catalogs)
            {
                Console.WriteLine(catalog.ToString());
            }
        }






        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.Items.AsQueryable().FirstOrDefault(predicate);
                if (item != null)
                {
                    return item;
                }
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(title);
                if (item != null)
                {
                    return item;
                }
            }
            return null;
        }

        public Item FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(id);
                if (item != null)
                {
                    return item;
                }
            }
            return null;
        }


    }
}
