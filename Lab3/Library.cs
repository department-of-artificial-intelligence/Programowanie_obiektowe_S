using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Library : IItemManagement
    {
        public string? Address {  get; set; }

        public IList<Librarian>? Librarians { get; set; }

        public IList<Catalog>? Catalogs { get; set; }

        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address;
            Librarians = librarians;
            Catalogs = catalogs;
        }

        public void AddLibrarian(Librarian librarian)
        {
            Librarians!.Add(librarian);
        }

        public void ShowAllLibrarians()
        {
            foreach(Librarian lib in Librarians!)
            {
                Console.WriteLine(lib);
            }
        }

        public void AddCatalog(Catalog catalog)
        {
            Catalogs!.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            for (int i = 0; i < Catalogs!.Count; i++)
            {
                if (Catalogs[i].ThematicDepartment == thematicDepartment)
                {
                    Catalogs[i].AddItem(item);
                }
            }
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            var compiledPredicate = predicate.Compile();

            foreach (Catalog catalog in Catalogs!)
            {
                var foundItem = catalog.Items.FirstOrDefault(compiledPredicate);
                if (foundItem != null)
                {
                    return foundItem;
                }
            }

            return null!;
        }

        public Item FindItemBy(int id)
        {
            foreach (Catalog catalog in Catalogs!)
            {
                Item temp = catalog.FindItemBy(id);
                if (temp != null) return temp;
            }
            return null!;
        }

        public Item FindItemBy(string title)
        {
            foreach (Catalog catalog in Catalogs!)
            {
                Item temp = catalog.FindItemBy(title);
                if (temp != null) return temp;
            }
            return null!;
        }

        public override string ToString()
        {
            string output = $"Address: {Address}" ?? "Address: No Address";
            output += $"\nLibrarians count: {Librarians!.Count}";

            foreach (var librarian in Librarians)
            {
                output += $"\n{librarian.ToString()}";
            }

            output += $"Catalogs count: {Catalogs!.Count}";

            foreach (var catalog in Catalogs)
            {
                output += $"\n{catalog.ToString()}";
            }

            return output;
        }
        public void ShowAllItems()
        {
            foreach (Catalog catalog in Catalogs!)
            {
                Console.WriteLine(catalog);
            }
        }
    }
}
