    
namespace lab3
{
    using System;
    using System.Linq.Expressions;

    internal class Catalog : ItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = items;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public Item? FindItem(Expression<Func<Item, bool>> predicate)
        {
            return Items.FirstOrDefault(predicate.Compile());
        }

        
        public Item? FindItemBy(string title)
        {
               return Items.FirstOrDefault(item => item.Title == title);
        }
        


        public Item? FindItemBy(int id)
        {
            return Items.FirstOrDefault(item => item.Id == id);
        }
        public override string ToString()
        {
            string items = "";
            foreach (var item in Items)
            {
                items += $"\n{item}";
            }
            return $"ThematicDepartment: {ThematicDepartment}" + items;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

    }
}
