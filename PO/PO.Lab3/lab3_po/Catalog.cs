using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public class Catalog
    {
        private IList<Item> Items = new List<Item>();
        private string _thematicDepartment;

        public IList<Item> Items1 { get => Items; set => Items = value; }
        public string ThematicDepartment { get => _thematicDepartment; set => _thematicDepartment = value; }

        public Catalog(IList<Item>items)
        {
            Items = items;
        }

        public Catalog(string thematicDepartment, IList<Item>items)
        {
            _thematicDepartment = thematicDepartment;
            Items = items;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            var str = $"thematic department: {_thematicDepartment}";
            str += string.Join < Item >('\n', Items);
            return str;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);  
        }
    }
}
