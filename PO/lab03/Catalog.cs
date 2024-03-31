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
        { get; set; }
        public string ThematicDepartment
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

    }
}
