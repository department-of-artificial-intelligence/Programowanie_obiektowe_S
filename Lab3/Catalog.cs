using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog (IList<Item> Items)
        {
            Items = new List<Item> ();
            ThematicDepartment = "none";
        }
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment=thematicDepartment;
            Items = items;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public string ToString() => $"Catalog {ThematicDepartment}, Items count: {Items.Count}";

        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
