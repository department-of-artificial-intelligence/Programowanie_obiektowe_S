using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog
    {
        public IList<Item> Items { get; set; }

        public string ThematicDepartment { get; set; }
        
        public Catalog(IList<Item> items)
        {
            Items = items ?? new List<Item>();
            ThematicDepartment = "Unknown";
        }

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = items ?? new List<Item>();
        }

        public void AddItem(Item item)
        {
           Items.Add(item);
        }

        public override string ToString()
        {
            return $"Catalog {ThematicDepartment}, Items count: {Items.Count}";
        }

        public void ShowAllItems()
        {
            foreach(var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
