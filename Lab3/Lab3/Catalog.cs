using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog
    {
        public IList<Item> Items{ get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> Items)
        {
            Items = new List<Item>(Items);        
        }
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = new List<Item>(items);
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Catalog: {ThematicDepartment}");
            foreach(Item item in Items)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            return sb.ToString();
        }
        public void ShowAllItems()
        {
            foreach(Item item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
