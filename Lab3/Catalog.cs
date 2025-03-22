using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }

        public string ThematicDepartment { get; set; }
        
        public Catalog(IList<Item> items)
        {
            Items = items ?? new List<Item>();
            ThematicDepartment = "Unknown";
        }

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = items ?? new List<Item>();
        }

        public Item FindItem(Predicate<Item> predicate)
        {
            //return Items.FirstOrDefault(item => predicate(item));

            foreach (var item in Items)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return null;
        }

        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(item => item.Title.Equals(title));
        }

        public Item FindItemBy(int id)
        {
            return Items.FirstOrDefault(item => item.Id.Equals(id));
        }

        public void AddItem(Item item)
        {
           Items.Add(item);
        }

        public override string ToString()
        {
            return $"Catalog {ThematicDepartment}, Items count: {Items.Count}";
        }

        public void ShowAllItems()
        {
            foreach(var item in Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
