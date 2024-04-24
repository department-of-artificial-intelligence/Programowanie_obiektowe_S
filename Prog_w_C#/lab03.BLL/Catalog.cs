using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03.BLL
{
    public class Catalog : ItemManagment
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items) 
        {
            Items = items;
        }
        public Catalog(string thematicDepartment , IList<Item> items) 
        { 
            ThematicDepartment = thematicDepartment;
            Items = items;
        }
        public void AddItem(Item item) 
        {
           Items.Add(item); 
        }
        public override string ToString() 
        {
            string przed = string.Empty;
            przed += string.Join("\n" , Items);
            return $"ThematicDepartment: {ThematicDepartment} Przedmioty:{przed}";
        }
        public void ShowAllItems()
        {
            Console.WriteLine(this);
        
        }
        public Item FindItemBy(int id)
        {
            foreach (var item in Items)
            {
                if (item.Id == id) return item;
            }
            return default;
        }
        public Item FindItemBy(string title)
        {
            foreach (var item in Items)
                if (item.Title == title)
                    return item;
            return default;
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            foreach (Item i in Items)
                if (predicate.Compile()(i))
                    return i;
            return default;
        }

    }
}
