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

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = items;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            return $"Catalog: {ThematicDepartment}, Items Count: {Items.Count}";
        }

        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
