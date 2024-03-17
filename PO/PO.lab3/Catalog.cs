using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Catalog
    {
        IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = string.Empty;
        }
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            Items = items;
            ThematicDepartment = thematicDepartment;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public Item? FindItem(Predicate<Item> match)
        {
            foreach (Item item in Items)
            {
                if (match(item)) 
                    return item;
            }
            return default;
        }
        public Item? FindItemBy(string title)
        {
            return Items.FirstOrDefault(item => item.Title == title);
        }
        public Item FindItemBy(int id)
        {
            return Items.First(item => item.ID == id);
        }
        public override string ToString()
        {
            string str = string.Empty;
            foreach (Item item in Items)
            {
                str += item.ToString();
            }
            return str + ThematicDepartment;
        }
        public void ShowAllItems()
        {
            Console.WriteLine("Catalog");
            Console.WriteLine(this);
        }
    }
}
