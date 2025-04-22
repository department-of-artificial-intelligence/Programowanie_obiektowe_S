using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            ThematicDepartment = "undefined";
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
        public Item FindItem(Func<Item, bool> predicate)
        {
            Item item = Items.FirstOrDefault(predicate);
            if (item != null)
                return item;
            return null;
        }
        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(i => i.Title == title);
        }
        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }
        public override string ToString()
        {
            string sCatalog = $"{ThematicDepartment}, Items count: {Items.Count}  ";
            foreach (var item in Items)
            {
                sCatalog += $"\n {item.ToString()}";
            }
            return sCatalog;
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
