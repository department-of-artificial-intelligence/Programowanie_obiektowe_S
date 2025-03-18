using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog
    {
        public IList<Item> Items=new List<Item>();
        public string ThematicDepartment {  get; set; }
        public Catalog(IList<Item> items)
        {
            ThematicDepartment = "nieznanytemat";
            Items = items;
        }
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment=thematicDepartment;
            Items = items;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            return $"THEMATIC DEPARMENT: {ThematicDepartment} ";
        }
        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                string Lista = "Lista: ";
                Console.WriteLine(Lista+item.ToString());
            }
        }


    }
}
