namespace PO.Lab3.Classes
{
    public class Library
    {
        public string Address { get; set; }
        IList<Librarian> Librians { get; set; }
        IList<Catalog> Catalogs { get; set; }

        public Library(string address, IList<Librarian> librians, IList<Catalog> catalogs)
        {
            Address = address;
            Librians = librians;
            Catalogs = catalogs;
        }

        public void AddLibrarian(Librarian librian)
        {
            Librians.Add(librian);
        }


        public void ShowAllLibrarians()
        {
            foreach (Librarian labrarian in Librians)
            {
                Console.WriteLine(labrarian.ToString());
            }
        }

        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            Catalogs.First(str => str.ThematicDepartment == thematicDepartment).AddItem(item);
        }

        public void ShowAllItems()
        {
            foreach (Catalog item in Catalogs)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public Item FindItem(Predicate<Item> match)
        {
            foreach (Catalog catalog in Catalogs)
            {
                return catalog.FindItem(match);
            }
            return default;
        }

        public Item FindItemBy(int id)
        {
            foreach (Catalog cat in Catalogs)
            {
                return cat.FindItemBy(id);
            }
            return default;
        }

        public Item FindItemBy(string title)
        {
            foreach (Catalog cat in Catalogs)
            {
                return cat.FindItemBy(title);
            }
            return default;
        }



    }
}

