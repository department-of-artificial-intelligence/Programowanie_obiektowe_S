using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab03
{
    public class Catalog : IItemManagment
    {
        public IList<Item> Items { get; set; }
        public string ?ThematicDepartment
        { get; set; }
        public Catalog(IList<Item>items) 
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
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            var foundedItem = Items.FirstOrDefault(predicate.Compile());
            return foundedItem;
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

        public override string ToString()
        {
            string a = $"Thematic Department: {ThematicDepartment}";
            if(Items!= null) 
            {
                foreach (Item i in Items)
                {
                    a += i.ToString();
                }
            }
            return a;
        }
        public void ShowAllItems() 
        {
            Console.WriteLine(this.ToString());
        }
    }
}
