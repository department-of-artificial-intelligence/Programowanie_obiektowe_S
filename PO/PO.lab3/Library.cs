using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    internal class Library : IItemManagement
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
            Console.WriteLine(ToString());
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddItem(Item item, string thematicDepartament)
        {

            Catalogs.First(tD => tD.ThematicDepartment == thematicDepartament).AddItem(item);
        }
        public void ShowAllItems()
        {
            foreach(Catalog catalog in Catalogs)
            {
               catalog.ShowAllItems();
            }
        }


        public Item FindItemBy(int id)
        {
            //  return Catalogs.FirstOrDefault(b => b.FindItemBy(id) != null);
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(id);
                if (item != null)
                    return item;
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
          //  return Catalogs.FirstOrDefault().FindItemBy(title);

            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(title);
                if (item != null)
                    return item;
            }
            return null;
        }

        /* public Item FindItem(Expression<Func<Item, bool>> expression)
        {
            return Catalogs.First().FindItem(expression.Compile());
        }*/
        public Item FindItem(Expression<Func<Item, bool>> expression)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItem(expression);
                if (item != null)
                    return item;
            }
            return null;
            //            return Catalogs.FirstOrDefault().FindItem(expression);
        }
        public override string ToString()
        {
            string catalogsInfo = "";
            string LibrariansInfo = "";
            foreach (var catalog in Catalogs)
            {
                catalogsInfo += catalog.ToString();
            }
            foreach (var librarians in Librarians)
            {
                LibrariansInfo += librarians.ToString();
            }
            return $"Address{Address} " + catalogsInfo + LibrariansInfo;
        }
    }
}
