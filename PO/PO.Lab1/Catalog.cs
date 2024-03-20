using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
    internal class Catalog
    {
        public IList<Item> Items { get; set; }
        public string? ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            Items = items;
        }
        public Catalog(string thematicDepartment, IList<Item> items) {
            ThematicDepartment = thematicDepartment;
            Items = items;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);

        }
        public override string ToString()
        {
            return $"Items: {Items}, Thematic department: {ThematicDepartment}\n";
        }

        public void ShowAllItems()
        {
            foreach(Item e in Items)
            {
                if (e != null)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
