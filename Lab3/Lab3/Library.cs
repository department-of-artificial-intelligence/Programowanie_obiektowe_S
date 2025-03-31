using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Library:IItemManagement
    {
        public string Address {  get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }

        public Library()
        {
            Address = "nieznany";
            Librarians = new List<Librarian>();
            Catalogs = new List<Catalog>();
        }

        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address;
            this.Librarians = librarians;
            this.Catalogs = catalogs;
        }
        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void ShowAllLibrarians()
        {
            foreach (Librarian lib in Librarians)
            {
                Console.WriteLine(lib);
            }
        }
        public void AddCatalog(Catalog catalog) 
        { 
            Catalogs.Add(catalog);
        }
        public void AddItem(Item item, string thematicDepartment)
        {
            if (item == null || string.IsNullOrWhiteSpace(thematicDepartment))
                throw new ArgumentException("Nieprawidłowy argument.");

            Catalog? catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);

            if (catalog == null)
                throw new Exception($"Nie znaleziono katalogu o dziale: {thematicDepartment}");

            catalog.AddItem(item);
        }

        public void ShowAllItems()
        {
            foreach (var catalog in Catalogs)
            { catalog.ShowAllItems(); }
        }
        public Item FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(id);
                if (item != null)
                    return item;
            }

            throw new Exception($"Nie znaleziono przedmiotu o ID: {id}");
        }
        public Item FindItemBy(string title)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(title);
                if (item != null)
                    return item;
            }

            throw new Exception($"Nie znaleziono przedmiotu o tytule: {title}");
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItem(predicate);
                if (item != null)
                    return item;
            }

            throw new Exception($"Nie znaleziono z pomoca predykatu");
        }
        public override string ToString()
        {
            return $"Adres {Address} ";
        }

    }
}
