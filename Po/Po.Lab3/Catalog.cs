using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab3
{
    internal class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        
        public Catalog(IList<Item> items) { 
        
            Items = items;
        }
        public Catalog(string thematicDepartment, IList<Item> items) { 
        
            Items = items;
            ThematicDepartment = thematicDepartment;
        }
        public void AddItem(Item Item)
        { Items.Add(Item); }
        public override string ToString()
        {
            return $"Thematic Department: {ThematicDepartment}";
        }
        public void ShowAllItems()
        {
            Console.WriteLine(this.ToString());
            foreach (Item e in Items)
            {
                if (e != null)
                {
                    Console.WriteLine("Item: "+e);
                }
            }
        }


        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(item => item.Id == id);
        }

        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(item => item.Title == title);
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
           Func<Item,bool> func = predicate.Compile();
            return Items.FirstOrDefault(func);
        }
    }
}
