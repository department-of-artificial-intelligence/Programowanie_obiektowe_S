using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Library: IIteManagement
    {
        public string Address { get; set; }
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
            foreach(var librarian in Librarians)
            {
                Console.WriteLine(librarian);
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        
        public void AddItem(Item item, string thematicDepartment)
        {
            foreach(var catalog in Catalogs)
            {
                if(thematicDepartment == catalog.ThematicDepartment)
                {
                    catalog.AddItem(item);
                }
            }
        }

        public void ShowAllItems()
        {
            foreach(var catalog in Catalogs)
            {
                catalog.ShowAllItems();
            }
        }

        public Item FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            {
                if (null != catalog.FindItemBy(id)) return catalog.FindItemBy(id);
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
            foreach (var catalog in Catalogs)
            {
                if (null != catalog.FindItemBy(title)) return catalog.FindItemBy(title);
            }
            return null;
        }

        public Item FindItem(Predicate<Item> predicate)
        {
            foreach (var catalog in Catalogs)
            {
                if (null == catalog.FindItem(predicate)) return catalog.FindItem(predicate);
            }
            return null;
        }

        public override string ToString()
        {
            string res = $"Address: {Address},\n Librarians: \n";
            foreach(var librarian in Librarians)
            {
                res += librarian.ToString();
            }
            res += "\n Catalogs: \n";
            foreach (var catalog in Catalogs)
            {
                res += catalog.ToString();
            }
            return res;
        }
    }
}
