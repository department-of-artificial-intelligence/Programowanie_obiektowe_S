using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Catalog
    {
        public IList<Item> _items;
        public string _thematicDepartment;

        public IList<Item> Items { get { return _items; }
            set { _items = value; }
           }

        public string ThematicDepartment
        {
            get { return _thematicDepartment; }
            set { _thematicDepartment = value; }
        }

        public Catalog(IList<Item> items)
        {
            Items = items;
        }

        public Catalog(string thematicDepartment,IList<Item> items)
        {
            Items = items; 
            ThematicDepartment = thematicDepartment;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            return $"ThematicDepartment={ThematicDepartment}";
        }

        public void ShowAllItems()
        {
            foreach (Item item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }



    }
}
