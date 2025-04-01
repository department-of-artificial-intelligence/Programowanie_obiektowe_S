using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal class Catalog : ItemManagment
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = "Brak";
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

        public override string ToString()
        {
            string rezultat = $"Catalog | ThematicDepartment: {ThematicDepartment}, Items: \n";
            foreach(Item item in Items)
            {
                rezultat += item.ToString() + "\n";
            }
            return rezultat;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this.ToString());
        }

        public Item FindItemBy(int id)
        {
            foreach (Item item in Items)
            {
                if (item.Id == id) return item; 
            }
            return null!;
        }

        public Item FindItemBy(string title)
        {
            foreach (Item item in Items) 
            {
                if(item.Title == title) return item;
            }
            return null!;
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            var item = Items.AsQueryable().FirstOrDefault(predicate);
            if (item != null) return item;
            return null!;
        }

    }
}
