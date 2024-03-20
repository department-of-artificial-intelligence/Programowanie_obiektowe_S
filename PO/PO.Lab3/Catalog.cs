using Lab3_PO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public IList<Item> Items1 { get => Items; set => Items = value; }
        public Catalog(IList<Item> items)
        {
            Items = items;
        }

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
            var str = $"thematic department: {ThematicDepartment}";
            str += string.Join<Item>('\n', Items);
            return str;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

        public Item FindItemBy(int id)
        {
            var foundedItem = Items.FirstOrDefault(b => b.Id == id);
            return foundedItem;
        }

        public Item FindItemBy(string title)
        {
            var foundedItem = Items.FirstOrDefault(b => b.Title == title);
            return foundedItem;
        }

        public Item FindItem(Expression<Func<Item, bool>>predicate)
        {
            var foundedItem = Items.FirstOrDefault(predicate.Compile());
            return foundedItem;
        } 
    }
}
