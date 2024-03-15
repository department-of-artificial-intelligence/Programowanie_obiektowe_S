using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public IList<Item> Items1 { get => Items; set => Items = value; }
        public Catalog(IList<Item> items)
        {
            Items = items;
        }

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
            var str = $"thematic department: {ThematicDepartment}";
            str += string.Join<Item>('\n', Items);
            return str;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }
    }
}
