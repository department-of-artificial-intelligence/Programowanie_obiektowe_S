using Laboratorium3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public class Catalog : IItemmanagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(string thematicDep, IList<Item> items)
        {
            ThematicDepartment = thematicDep;
            Items = items;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);

        }
        public override string ToString()
        {
            return $"Department: {ThematicDepartment}, items: {Items.Count}";
        }

        public void ShowAllItems()
        {
            foreach(var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(item => item.Id == id);
        }

        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(item => item.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            return Items.AsQueryable().FirstOrDefault(predicate);
        }




    }
}