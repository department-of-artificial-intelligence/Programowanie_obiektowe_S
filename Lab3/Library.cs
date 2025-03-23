using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Library : ItemManagement
    {
        public string Address
        {
            get;
            set;
        }

        public IList<Librarian> Librarians
        {
            get;
            set;
        }

        public IList<Catalog> Catalogs
        {
            get;
            set;
        }

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
            Console.WriteLine("All librarians:");
            foreach (var i in Librarians)
                Console.WriteLine(i.ToString());
        }

        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            bool check = false;
            foreach (var i in Catalogs)
            {
                if(thematicDepartment == i.ThematicDepartment)
                {
                    i.AddItem(item);
                    check = true;
                    break;
                }
            }
            if (check == false)
                Console.WriteLine("Nie znaleziono wybranego działu tematycznego.");
        }

        public void ShowAllItems()
        {
            foreach (var i in Catalogs)
                i.ShowAllItems();
        }

        public Item FindItemBy(int id)
        {
            return FindItem(Items => Items.Id == id);
        }

        public Item FindItemBy(string title)
        {
            return FindItem(Items => Items.Title == title);
        }

        public Item FindItem(Func<Item, bool> predicate)
        {
            foreach (var i in Catalogs)
                return i.FindItem(predicate);
            return null!;
        }

        public override string ToString()
        {
            string details = $"Library: | Address: {Address}, Librarians:\n";
            foreach (var i in Librarians)
                details += i.ToString();
            details += "\nCatalogs:\n";
            foreach (var i in Catalogs)
                details += i.ToString();
            return details;
        }
    }
}
