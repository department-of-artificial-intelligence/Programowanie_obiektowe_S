using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab3
{
    internal class Catalog: IIteManagement
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
            Items = items;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public Item FindItem(Predicate<Item> predicate)
        {
            foreach(var item in Items)
            {
                if (predicate(item)) return item;
            }
            return null;
        }
            
        public Item FindItemBy(string title)
        {
            //Console.WriteLine(Items.Where(item => item.Title == title;
            foreach (var item in Items)
            {
                if (title == item.Title ) return item;
            }
            return null;
        }

        public Item FindItemBy(int id)
        {
            //Console.WriteLine(Items.Where(item => item.Id == id;
            foreach (var item in Items)
            {
                if (id == item.Id) return item;
            }
            return null;
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
