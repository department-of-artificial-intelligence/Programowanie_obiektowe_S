using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab3
{
    internal class Catalog
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
    }
}
