using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Catalog : ItemManagement
    {
        public IList<Item>? Items
        {
            get;
            set;
        }

        public string ThematicDepartment
        {
            get;
            set;
        }

        public Catalog(IList<Item> items)
        {
            ThematicDepartment = "nieznany";
            Items = items;
        }

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = items;
        }

        public void AddItem(Item item)
        {
            Items!.Add(item);
        }

        public Item FindItem(Func<Item, bool> predicate)
        {
            return Items!.FirstOrDefault(predicate)!;
        }

        public Item FindItemBy(string title)
        {
            return FindItem(Items => Items.Title == title);
        }

        public Item FindItemBy(int id)
        {
            return FindItem(Items => Items.Id == id);
        }

        public override string ToString()
        {
            string detail = "Items:\n";
            foreach (var i in Items!)
            {
                detail += i.ToString();
            }
            return detail + $"ThemematicDepartment: {ThematicDepartment}\n";
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
