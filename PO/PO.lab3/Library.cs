using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal class Library : IItemManagement
    {

        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }

        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs) {

            Address = address;
            Librarians = librarians;
            Catalogs = catalogs;

        }

        public void AddLibrarian(Librarian librarian) {

            Librarians.Add(librarian);

        }

        public void ShowAllLibrarians() {

            foreach (var item in Librarians)
            {

                Console.WriteLine(item);

            }

        }

        public void AddCatalog(Catalog catalog)
        {

            Catalogs.Add(catalog);

        }

        public void AddItem(Item item, string thematicDepartment) {

            Catalogs.First(i => i.ThematicDepartment == thematicDepartment).AddItem(item);

        }

        public void ShowAllItems()
        {

            foreach (var item in Catalogs) {

                Console.WriteLine(item);

            }

        }

        public Item FindItemBy(int id) {

            foreach (var item in Catalogs)
            {

                var tmp = item.FindItemBy(id);
                if (tmp != null)
                    return tmp;

            }

            return null;

        }

        public Item FindItemBy(string title) {

            foreach (var item in Catalogs) { 
            
                var tmp = item.FindItemBy(title);
                if (tmp != null)
                    return tmp;
            
            }

            return null;
        
        }

        public Item FindItem(Expression<Func<Item, bool>> expression) { 
        
            foreach(var item in Catalogs)
            {

                var tmp = item.FindItem(expression);
                if (tmp != null)
                    return tmp;

            }
            return null;
        
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Library:");
            sb.AppendLine($"Address: {Address}");
            sb.AppendLine($"Librarians:");
            foreach (var item in Librarians) {

                Console.WriteLine(item);

            }

            sb.AppendLine($"Catalogs");
            foreach(var item in Catalogs)
            {

                Console.WriteLine(item);

            }



            return sb.ToString();
        }
    }
}
