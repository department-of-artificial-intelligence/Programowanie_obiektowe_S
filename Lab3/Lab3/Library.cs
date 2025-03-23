using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Library : IItemManagement
    {
        public string? Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }
        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address ?? "No Address";
            Librarians = librarians ?? new List<Librarian>();
            Catalogs = catalogs ?? new List<Catalog>();
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
        public void AddItem(Item item, string thematicDepartment)
        {
            var catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment.Equals(thematicDepartment));
            if (catalog != null)
            {
                catalog.AddItem(item);
                Console.WriteLine($"Item added to the '{thematicDepartment}' catalog.");
            }
            else
            {
                catalog = new Catalog(thematicDepartment, new List<Item> { item });
                Catalogs.Add(catalog);
                Console.WriteLine($"New catalog for '{thematicDepartment}' created and item added.");
            }
        }
        public void ShowAllItems()
        {
            foreach (var catalog in Catalogs)
            {
                Console.WriteLine($"Items in catalog {catalog.ThematicDepartment}");
                catalog.ShowAllItems();
            }
        }
        public Item FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(id);
                if (item != null)
                {
                    return item;
                }
            }
            return Activator.CreateInstance<Item>();
        }
        public Item FindItemBy(string title)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItemBy(title);
                if (item != null)
                {
                    return item;
                }
            }
            return Activator.CreateInstance<Item>();
        }
        public Item FindItem(Predicate<Item> predicate)
        {
            foreach (var catalog in Catalogs)
            {
                var item = catalog.FindItem(predicate);
                if (item != null)
                {
                    return item;
                }
            }
            return Activator.CreateInstance<Item>();
        }
        public override string ToString()
        {
            string output = $"Address: {Address}" ?? "Address: No Address";
            output += $"\nLibrarians count: {Librarians.Count}";
            foreach (var librarian in Librarians)
            {
                output += $"\n{librarian.ToString()}";
            }
            output += $"Catalogs count: {Catalogs.Count}";
            foreach (var catalog in Catalogs)
            {
                output += $"\n{catalog.ToString()}";
            }
            return output;
        }
    }
}