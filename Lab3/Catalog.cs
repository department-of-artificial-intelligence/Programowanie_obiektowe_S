using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog( IList<Item> items, string thematicDep = "none") 
        {
            ThematicDepartment = thematicDep;
            Items = items;
        }
        public void AddItem(Item item) 
        {
           //todo logika      
        }



    }
}
