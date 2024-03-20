using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Lab3
{
    public class Catalog
    {
        public IList<Item> Items {get; set;}
        public string ThemathicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            Items = items;
            ThemathicDepartment = string.Empty;
        }

        public Catalog(string themathicDepartment, IList<Item> items)
        {
            Items = items;
            ThemathicDepartment = themathicDepartment;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string output = "Items: [";
            foreach (Item item in Items) { output += item.ToString() + ", "; }
            output += "], ThematicDepartment: " + ThemathicDepartment;
            return output;
        }

        public void ShowAllItems()
        {
            string output = "[";
            foreach (Item item in Items) { output += item.ToString() + ", "; }
            output += "]";
            Console.WriteLine(output);
        }
    }
}
