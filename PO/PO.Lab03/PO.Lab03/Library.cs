using System.Linq.Expressions;

namespace PO.Lab03
{
    internal class Library : IItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }


        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address;
            Librarians = new List<Librarian>(librarians);
            Catalogs = new List<Catalog>(catalogs);
        }

        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }

        public void ShowAllLibrarians()
        {
            foreach (var item in Librarians)
            {
                Console.WriteLine(item);
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
            foreach (var i in Catalogs)
                i.ShowAllItems();
        }

        //IItemMenagment
        public Item FindItemBy(int id)
        {
            foreach (var i in Catalogs)
                foreach (var j in i.Items)
                    if (j.Id == id)
                        return j;

            return default;
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
            string a = "";
            foreach (var j in Librarians)
            {
                a += j.ToString();
                a += "\n";
            }


            foreach (var i in Catalogs)
            {
                a += i.ToString();
                a += "\n";
            }



            return $"== Library == | Address: {Address}, \n{a}";
        }



    }

}
