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
            Catalogs.FirstOrDefault(catalog => catalog.ThematicDepartment == thematicDepartment);
        }
       /* public void ShowAllItems()
        {
            Console.WriteLine(this.ToString());
            foreach (Item e in Items)
            {
                if (e != null)
                {
                    Console.WriteLine("Item: " + e);
                }
            }
        }
        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(item => item.Id == id);
        }

        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(item => item.Title == title);
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            Func<Item, bool> func = predicate.Compile();
            return Items.FirstOrDefault(func);
        }*/
    }
}
