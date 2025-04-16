using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Catalog
    {
        public IList<Item>? Items { get; set; }
        public string? ThematicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            Items = items;
        }

		public Catalog(string thematicDepartment, IList<Item> items)
		{
			Items = items;
            ThematicDepartment = thematicDepartment;
		}

        public void AddItem(Item item)
        {
            Items?.Add(item);
        }

		public override string ToString()
		{
            string items = "";
            if(Items != null)
                foreach (var item in Items)
                    items += item.ToString();
			return $"Thematic Department: {ThematicDepartment}\nItems:\n{items}";
		}

        public void ShowAllItems() 
        {
			Console.WriteLine(ToString());
        }
	}
}
