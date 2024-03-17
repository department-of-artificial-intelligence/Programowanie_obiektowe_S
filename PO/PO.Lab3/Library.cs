using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
        public void AddItem(Item item,string thematicDepartment)
        {
            Catalogs.First(i=>i.ThematicDepartment==thematicDepartment).AddItem(item);
        }
        public void ShowAllItems()
        {
            foreach (var item in Catalogs)
            {
                Console.WriteLine(item);
            }
        }

        public Item FindItemBy(int id)
        {
            foreach(var item in Catalogs)
            {
                var tmp = item.FindItemBy(id);
                if (tmp != null)
                    return tmp;
            }
            return null;
        }

        public Item FindItemBy(string title)
        {
            foreach (var item in Catalogs)
            {
                var tmp = item.FindItemBy(title);
                if (tmp != null)
                    return tmp;
            }
            return null;
        }

        public Item FindItem(Expression<Func<Item, bool>> expression)
        {
            foreach (var item in Catalogs)
            {
                var tmp = item.FindItem(expression);
                if (tmp != null)
                    return tmp;
            }
            return null;
        }
        public override string ToString()
        {
            string res = "Librarians : \n";
            foreach (var item in Librarians)
            {
                res+="\t"+item + "\n";
            }
            res += "Catalogs : \n";
            foreach (var item in Catalogs)
            {
                res += "\t" + item + "\n";
            }
            return res;
        }
    }
}
