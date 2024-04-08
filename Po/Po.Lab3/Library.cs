using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab3
{
    internal class Library : IItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }
        public Library(string address, IList<Librarian> librarians
            ,IList<Catalog> catalogs) { 
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
            
            foreach (Librarian e in Librarians)
            {
                if (e != null)
                {
                    Console.WriteLine("Librarians: " + e);
                }
            }
        }
        public void AddCatalog(Catalog catalog)
        {
           Catalogs.Add(catalog);
        }
        public void AddItem(Item item, string thematicDepartment)
        {
            var catalog = Catalogs.FirstOrDefault(catalog => catalog.ThematicDepartment == thematicDepartment);
            if (catalog != null)
            {
                catalog.Items.Add(item);
            }
            else
            {
                Console.WriteLine("nie mozna dodac");
            }
        }
        public void ShowAllItems()
        {
            Console.WriteLine(this.ToString());
            IList<Item> items = new List<Item>();
            foreach (Item e in items)
            {
                if (e != null)
                {
                    Console.WriteLine("Item: " + e);
                }
            }
        }
        public Item? FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            { 
                var item = catalog.Items.FirstOrDefault(item => item.Id == id);
                if (item != null)
                { 
                    return item; 
                }
                
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
           foreach(var catalog in Catalogs)
            {
                var item = catalog.Items.FirstOrDefault(item => item.Title == title);
                if (item != null)
                { 
                    return item;
                }
            }
            return null;
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {

            foreach (var catalog in Catalogs)
            {
                if (catalog.Items != null)
                {
                    foreach (var item in catalog.Items)
                    {
                        Func<Item, bool> func = predicate.Compile();

                        if (func(item))
                        {
                            return item;
                        }
                    }
                }
            }
            return null;
        }
        public override string ToString()
        {
            string libNames = string.Join(", ", Librarians.Select(a => a.ToString()));
            string catNames = string.Join(", ", Catalogs.Select(a => a.ToString()));
            return $"Address: {Address}, Librarians: {libNames}, Catalogs: {catNames}";
        }
    }
}
