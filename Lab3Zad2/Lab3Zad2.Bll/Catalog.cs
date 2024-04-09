using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Zad2.Bll
{
    public class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            Items = new List<Item>(items);
            ThematicDepartment = "none";
        }

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            Items = new List<Item>(items);
            ThematicDepartment = thematicDepartment;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder str_list = new StringBuilder();
            foreach (var i in Items)
            {
                str_list.Append(i + "\n");
            }
            return $"Catalog: {ThematicDepartment} Lista: {str_list}";
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

        public Item FindItem(Expression<Func<Item, bool>> lambda)
        {
            var a = lambda.Compile();
            var Result = Items.FirstOrDefault(a);
            return Result;
        }

        public Item FindItemBy(int id)
        {
            var result = Items.FirstOrDefault(i => i.Id == id);
            return result;
        }

        public Item FindItemBy(string title)
        {
            var result = Items.FirstOrDefault(i => i.Title == title);
            return result;
        }
    }
}
