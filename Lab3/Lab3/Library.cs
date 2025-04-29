namespace Lab3
{
    public class Library : IItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }

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
            foreach (Librarian librarian in Librarians)
            {
                Console.WriteLine("\t" + librarian);
            }
        }

        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            foreach (Catalog catalog in Catalogs)
            {
                if (catalog.ThematicDepartment == thematicDepartment)
                {
                    catalog.AddItem(item);
                    return;
                }
            }
        }

        public void ShowAllItems()
        {
            foreach (Catalog catalog in Catalogs)
            {
                Console.WriteLine(catalog);
            }
        }

        public Item FindItemBy(int id)
        {
            foreach (Catalog catalog in Catalogs)
            {
                Item temp = catalog.FindItemBy(id);
                if (temp != null) return temp;
            }
            return null!;
        }

        public Item FindItemBy(string title)
        {
            foreach (Catalog catalog in Catalogs)
            {
                Item temp = catalog.FindItemBy(title);
                if (temp != null) return temp;
            }
            return null!;
        }

        public Item FindItem(Predicate<Item> predicate)
        {
            foreach (Catalog catalog in Catalogs)
            {
                Item temp = catalog.FindItem(predicate);
                if (temp != null) return temp;
            }
            return null!;
        }

        public override string ToString()
        {
            string temp = $"Adres: {Address}";
            if (Librarians.Count > 0) temp += ", Bibliotekarze: \n";
            foreach (Librarian librarian in Librarians)
            {
                temp += $"\t{librarian},\n";
            }
            if (Catalogs.Count > 0) temp += "Katalogi: \n";
            foreach (Catalog catalog in Catalogs)
            {
                temp += $"\t{catalog}, \n";
            }

            return temp;
        }
    }
}
