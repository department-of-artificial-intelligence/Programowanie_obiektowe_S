using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Catalog : IItemManagement
    {
        public IList<Item> Items
        {
            get; set;
        }
        public string ThematicDepartment
        {
            get; set;
        }
        public Catalog(IList<Item> items)
        {
            this.Items = items;
            ThematicDepartment = string.Empty;
        }
        public Catalog(string thematicDepartmemt, IList<Item> items)
        {
            this.Items = items;
            ThematicDepartment = thematicDepartmemt;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        public override string ToString()
        {
            string str = "";
            foreach (Item item in Items)
            {
                str += item.ToString();
            }
            return $"ThematicDepartment: {ThematicDepartment}, Items: {str} ";
        }
        public void ShowAllItems()
        {
            string str = "";
            foreach(Item item in Items)
            {
                str += item.ToString();
            }
            Console.WriteLine(str);
        }
        public Item FindItemBy(int id)
        {
            return Items.First(str => str.Id == id);
        }

        public Item FindItemBy(string title)
        {
            return Items.FirstOrDefault(str => str.Title == title);
        }

        public Item FindItem(Expression<Func<Item, bool>> expression)
        {
            return Items.FirstOrDefault(expression.Compile());
        }
    }
}
