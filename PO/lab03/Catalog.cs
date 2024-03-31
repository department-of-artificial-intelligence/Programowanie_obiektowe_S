using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab03
{
    public class Catalog
    {
        public IList<Item>?Items
        {
            get => Items;
            set => Items = value; 
        }
        public string ?ThematicDepartment
        { get; set; }
        public Catalog(IList<Item>items) 
        {
            Items = new List<Item>();
            Items = items;
        }
        public Catalog(string thematicDepartment, IList<Item> items) 
        {
            ThematicDepartment = thematicDepartment;
            Items = new List<Item>();
            Items = items;
        }
        public void AddItem(Item item) 
        {
            Items.Add(item);
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
