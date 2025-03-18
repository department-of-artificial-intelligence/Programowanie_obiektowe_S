using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
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
            string result = $"thematic deparment: {ThematicDepartment}\n";
            foreach (var item in Items) 
            { 
                result += item.ToString() ;
                result += "\n";
            }
            return result ;
        }

        public void ShowAllItems()
        {
            string result = string.Empty;
            foreach (var item in Items)
            {
                result += item.ToString();
                result += "\n";
            }
            Console.WriteLine(result);
        }



    }
}
