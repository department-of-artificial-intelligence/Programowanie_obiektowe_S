using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3
{
    internal class Catalog
    {
        public IList<Item> Items {  get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            ThematicDepartment = "unknown";
            Items = items;
        }
        public Catalog(string thematicDepartment,IList<Item> items) : this(items)
        {
            ThematicDepartment = thematicDepartment;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            string res = $"ThematicDepartment:{ThematicDepartment}";
            foreach (var item in Items)
            {
                res += '\n' + '\t' + item.ToString();
            }
            return res;
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
