using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Catalog:IItemManagement
    {
        public IList<Item>? _items;
        public string? _thematicDepartment;

        public IList<Item> Items { get { return _items!; }
            set { _items = value; }
           }

        public string ThematicDepartment
        {
            get { return _thematicDepartment!; }
            set { _thematicDepartment = value; }
        }

        public Catalog(IList<Item> items)
        {
            Items = items;
        }

        public Catalog(string thematicDepartment,IList<Item> items)
        {
            Items = items; 
            ThematicDepartment = thematicDepartment;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            return $"ThematicDepartment={ThematicDepartment}";
        }

        public void ShowAllItems()
        {
            foreach (Item item in Items)
            {
                Console.WriteLine(item);
            }
        }       

        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(item => item.Id.Equals(id))!;
        }

        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(item => item.Title.Equals(title))!;
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            var compiledPredicate = predicate.Compile();
            return Items.FirstOrDefault(compiledPredicate)!;
        }

        internal static object FirstOrDefault(Func<Item, bool> compiledPredicate)
        {
            throw new NotImplementedException();
        }
    }
}
