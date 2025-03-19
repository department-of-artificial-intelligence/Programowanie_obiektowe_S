using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog : Item
    {
        public IList<Item> Items { get; set; }

        public string ThematicDepartment { get; set; }
        
        public Catalog(IList<Item> items)
        {
            Items = items ?? new List<Item>();
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

        public string GenerateBarCode()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Thematic Department: {ThematicDepartment}");
            sb.AppendLine("Items in Catalog:");

            foreach (var item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        public override string ToString()
        {
            foreach(var item in Items)
            {
                return base.ToString();
            }
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }
    }
}
