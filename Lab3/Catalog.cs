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
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Catalog: {ThematicDepartment}");
            sb.AppendLine("Items:");

            foreach(var item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }
    }
}
