using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Library : ItemManagement
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
            foreach (var librarian in Librarians)
            {
                Console.WriteLine(librarian);
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }


        public void ShowAllItems()
        {
            foreach (var catalog in Catalogs)
            {
                Console.WriteLine(catalog.ThematicDepartment);
                foreach (var item in catalog.Items)
                {
                    item.Details();
                }
            }
        }
        public void AddItem(Item item, string thematicDepartment)
        {
            Catalogs.First(catalogs => catalogs.ThematicDepartment == thematicDepartment).Items.Add(item);
        }

        public Item? FindItem(Expression<Func<Item, bool>> predicate)
        {
            return Catalogs.SelectMany(catalog => catalog.Items).FirstOrDefault(predicate.Compile());
        }

        public Item? FindItemBy(string title)
        {
            return Catalogs.SelectMany(catalog => catalog.Items).FirstOrDefault(item => item.Title == title);
        }

        //public Item? FindItemBy(int id)
        //{
        //  return Catalogs.SelectMany(catalog => catalog.Items).FirstOrDefault(item => item.Id == id);
        //}

        public Item? FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            {

                foreach (var item in catalog.Items)
                {
                    if (id == item.Id)
                    {
                        return item;
                    }

                }
            }
            return null;
        }
    }
}
