using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Bll
{
    public class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            Items = new List<Item>(items);
            ThematicDepartment = "none";
        }

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            Items = new List<Item>(items);
            ThematicDepartment = thematicDepartment;
        }

        public void AddItem(Item item) { Items.Add(item); }
        public override string ToString()
        {
            string przed = string.Empty;
            przed += string.Join("\n", Items);
            return $"ThematicDepartment: {ThematicDepartment} Przedmioty:{przed}";
        }
        public void ShowAllItems()
        {
            Console.WriteLine(this.ToString());
            foreach (Item e in Items)
            {
                if (e != null)
                {
                    Console.WriteLine("Item: " + e);
                }
            }
        }
    }
}
