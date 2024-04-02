using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab03
{
    public class Library : IItemManagment
    {
        public string Address { get; set; }
        public IList <Librarian>? Librarians { get; set; }
        public IList<Catalog>? Catalogs { get; set; }
        public Library(string address, IList<Librarian>librarians, IList<Catalog>catalogs)
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
            if (Librarians != null) 
            { 
                foreach (Librarian L in Librarians)
                    Console.WriteLine(L.ToString());
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddItem(Item item, string thematicDepartment)
        {
            Catalog catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);
            if (catalog != null)
            {
                catalog.AddItem(item);
            }
        }
        public void ShowAllItems()
        {
            if(Catalogs != null)
            {
                foreach(Catalog C in Catalogs)
                    Console.WriteLine(C.ToString());
            }
        }
        public Item FindItemBy(int id)
        {
            var foundedItem = Catalogs.FindItemBy(id);
        }
        public Item FindItemBy(string title)
        {
            return null;
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            return null;
        }
    }
}
