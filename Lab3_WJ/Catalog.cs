using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_WJ
{
    public class Catalog
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            Items = items;
            ThematicDepartment = "Brak";
        }
        public Catalog(string thematicDepartment, IList <Item> items)
        {
            Items = items;
            ThematicDepartment = thematicDepartment;
        }

    }
}
