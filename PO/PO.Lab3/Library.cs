using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static PO.Lab3.Program;

namespace PO.Lab3
{
    public class Library : IItemManagment
    {
        public string Address { get; set; }
        IList<Librarian> Librarians { get; set; }
        IList<Catalog> Catalogs { get; set; }
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
            foreach (var item in Librarians)
            {
                Console.WriteLine(item + "\n");
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void ShowAllItems()
        {
            throw new NotImplementedException();
        }

        public Item FindItemBy(int id)
        {
            throw new NotImplementedException();
        }

        public Item FindItemBy(string title)
        {
            throw new NotImplementedException();
        }

        public Item FindItem(Expression<Func<Item, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
