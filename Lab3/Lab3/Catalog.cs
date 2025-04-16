using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Catalog : IItemManagment
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

		public Item FindItem(Expression<Func<Item, bool>> predicate)
		{
			var item = Items?.AsQueryable().FirstOrDefault(predicate);
			if (item != null)
				return item;
			return null;
		}

		public Item FindItemBy(string title)
        {
            var item = Items?.AsQueryable().FirstOrDefault(i => i.Title == title);
			if (item != null)
			    return item;
            return null;
        }

		public Item FindItemBy(int id)
		{
			var item = Items?.AsQueryable().FirstOrDefault(i => i.Id == id);
			if (item != null)
				return item;
			return null;
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
