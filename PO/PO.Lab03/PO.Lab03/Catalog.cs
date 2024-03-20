using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PO.Lab03
{
    internal class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; } = null!;


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
            string str = $"Catalog | ThematicDepartment: {ThematicDepartment} ";
            foreach (var item in Items)
            {
                str += item.ToString();
            }
            return str;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

    }
}
