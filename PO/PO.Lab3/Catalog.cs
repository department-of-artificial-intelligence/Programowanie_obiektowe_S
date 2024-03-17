using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab3
{
    public class Catalog : IItemManagment
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = string.Empty;
        }
        public Catalog(string thematicDepartment, IList<Item> items) : this(items)
        {
            ThematicDepartment = thematicDepartment;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            string res = $"Catalog : {ThematicDepartment} :\n\t";
            foreach (Item item in Items)
                res += item.ToString() + "\n\t";
            return res;
        }
        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(i => i.Id == id);
        }

        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(i => i.Title == title);
        }

        public Item FindItem(Expression<Func<Item, bool>> expression)
        {
            return Items.FirstOrDefault(expression.Compile());
        }
    }
}
