using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Zad2.Bll
{
    public class Library : ItemManagment
    {
        public string Adress { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }
        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Adress = address;
            Librarians = librarians;
            Catalogs = catalogs;
        }
        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void ShowAllLibrarians()
        {
            foreach (var i in Librarians)
            {
                Console.WriteLine(i);
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddItem(Item item, string thematicDepartment)
        {
            foreach (var i in Catalogs)
            {
                if (i.ThematicDepartment == thematicDepartment)
                    i.Items.Add(item);
            }
        }
        public void ShowAllItems()
        {
            for (int i = 0; i < Catalogs.Count; ++i)
            {
                Catalogs[i].ShowAllItems();
            }
        }
        public Item FindItemBy(int id)
        {
            foreach (var i in Catalogs)
                foreach (var j in i.Items)
                    if (j.Id == id)
                        return j;

            return default; ;
        }
        public Item FindItemBy(string title)
        {
            foreach (var i in Catalogs)
                foreach (var j in i.Items)
                    if (j.Title == title)
                        return j;

            return default;
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            foreach (var i in Catalogs)
                foreach (var j in i.Items)
                    if (predicate.Compile()(j))
                        return j;

            return default;
        }
        public override string ToString()
        {
            string cat = string.Join("\n ", Catalogs.Select(Catalogs => Catalogs.ToString()));
            string lib = string.Join("\n", Librarians.Select(LibLibrarians => Librarians.ToString()));
            return cat + lib + $"Adres: {Adress}";
        }
    }
}
