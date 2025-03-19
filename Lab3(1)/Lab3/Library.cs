using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Library : IItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs {get; set; }
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
            string result = "All Librarians:\n";
            foreach(var librarian in Librarians)
            {
                result += librarian.ToString();
                result += "\n";
            }
            Console.WriteLine(result);
        }

        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        //public Item FindItemBy(string tittle) => Items.FirstOrDefault(item => item.Title == tittle);
        public void AddItem(Item item, string thematicDepartment)
        {
            var catalog = Catalogs.FirstOrDefault(skladowe => skladowe.ThematicDepartment == thematicDepartment);
            if(catalog != null)
            {
                catalog.AddItem(item);
            }
        }

        public void ShowAllItems()
        {
            string result = "All items in catalogs:\n";
            foreach(var catalog in Catalogs)
            {
                result += catalog.ToString();
                result += "\n";
            }
            Console.WriteLine(result);
        }
        //public Item FindItemBy(int id) => Items.FirstOrDefault(item=>item.id==id)
        public Item FindItemBy(int id)
        {
            foreach(var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(id);
                if(item != null)
                {
                    return item;
                }
            }
            return null;
        }
        public Item FindItemBy(string tittle) 
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(tittle);
                if(item != null)
                {
                    return item;
                }
            }
            return null;
        }

        //Kroki w jakich działa ta metoda
        //1) Przechodzimy po katalog
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            foreach(var catalog in Catalogs)
            { 
    
                var foundItem = catalog.FindItem(predicate);

                if (foundItem != null)
                    return foundItem;
            }
            return null;
        }

        public override string ToString()
        {
            string result = $"Library Adres: {Address},\nLibrarinas:\n";

            foreach (var librarian in Librarians)
            {
                result += librarian.ToString();
                result += "\n";
            }

            result += "Catalogs:\n";
            foreach (var catalog in Catalogs){
                result += catalog.ToString();
                result += "\n";
            }

            return result;
        }
    }
}
