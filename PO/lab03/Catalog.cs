using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            this.Items = items;
        }
        public Catalog(string dep, IList<Item> items) : this(items)
        {
            this.ThematicDepartment = dep;
        }
        public void AddItem(Item item)
        {
            this.Items.Add(item);
        }
        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }
        public Item FindItem(Expression<Func<Item, bool>> func)
        {
            return Items.First(func.Compile());
        }
        public Item FindItemBy(int id)
        {
            return Items.First(item => item.Id == id);
        }
        public Item FindItemBy(string title)
        {
            return Items.First(item => item.Title == title);
        }
        public override string ToString()
        {
            return $"Catalog {ThematicDepartment}";
        }
    }
}
