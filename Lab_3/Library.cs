using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Library : ItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; } = new List<Librarian>();
        public IList<Catalog> Catalogs { get; set; } = new List<Catalog>();
        public IList<Item> Items { get; set; } = new List<Item>();

        public Library (string address, IList<Librarian> librarians, IList<Catalog> catalogs)
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
            Console.WriteLine(string.Join("\n",Librarians));
        }
        public void  AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddItem(Item item,string thematDepartment)
        {
            Items.Add(item);
        }
        public void ShowAllItems()
        {
            Console.WriteLine(string.Join("\n", Items));
        }
        public Item FindItemBy(int id)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (id == Items[i].Id)
                {
                    return Items[i];
                }
            }
            return null;
        }
        public Item FindItemBy(string title)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (title == Items[i].Title)
                {
                    return Items[i];
                }
            }
            return null;
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (predicate.Compile()(Items[i]))
                {
                    return Items[i];
                }
            }
            return null;
        }
        public string Tostring()
        {
            return string.Join("\n", Items) + $"Address: {Address}";
        }
    }
}
