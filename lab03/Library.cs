using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Library : ItemManagment
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set;}
        public IList<Catalog> Catalogs { get; set; }

        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address;
            Librarians = librarians;
            Catalogs = catalogs;
        }

        public void AddLibrarian(Librarian librarian) => Librarians.Add(librarian);
        
        public void ShowAllLibrarians()
        {
            Console.WriteLine("Library | Librarians:\n");
            foreach(Librarian librarian in Librarians)
            {
                Console.WriteLine($"\t{librarian}\n");
            }
        }

        public void AddCatalog(Catalog catalog) => Catalogs.Add(catalog);

        public void AddItem(Item item, string thematicDepartment)
        {
            foreach (Catalog catalog in Catalogs)
            {
                if (catalog.ThematicDepartment == thematicDepartment)
                {
                    catalog.AddItem(item);
                }
            }
        }

        public void ShowAllItems()
        {
            Console.WriteLine("Library | Items: \n");
            foreach(Catalog catalog in Catalogs)
            {
                Console.WriteLine(catalog);
            }
        }

        public Item FindItemBy(int id)
        {
            foreach(Catalog catalog in Catalogs)
            {
                Item temp = catalog.FindItemBy(id);
                if(temp != null) return temp;
            }
            return null!;
        }

        public Item FindItemBy(string title)
        { 
            foreach(Catalog catalog in Catalogs)
            {
                Item temp = catalog.FindItemBy(title);
                if(temp != null) return temp;
            }
            return null!;
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItem(predicate);
                if (item != null) return item;
            }

            return null!;
        }

        public override string ToString()
        {
            string temp = null!;
            foreach(Librarian librarian in Librarians) { temp += librarian.ToString(); }
            foreach(Catalog catalog in Catalogs) { temp += catalog.ToString(); }
            return $"Library | Addres: {Address}\n" + temp;
        }
    }
}
