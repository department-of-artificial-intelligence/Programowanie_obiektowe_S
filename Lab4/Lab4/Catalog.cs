using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Catalog 
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment {  get; set; }

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
            string temp = $"ThematicDepartment:{ThematicDepartment}";
            if (Items != null) temp += ", Items:";
            foreach (Item item in Items)
            {
                temp += $"\n\t{item}";
            }
            return temp;
        }

        public void ShowAllItems()
        {
            foreach (Item item in Items)
            {
                Console.WriteLine(item);
            }
        }


    }
}
