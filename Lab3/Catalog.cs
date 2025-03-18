using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
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
            ThematicDepartment = String.Empty;
            Items = items;
        }
        public Catalog(string thematicDepartments, IList<Item> items)
        {
            ThematicDepartment = thematicDepartments;
            Items = items;
        }
        public void AddItem(Item item) { Items.Add(item); }
        public override string ToString()
        {
            return $"ThematicDepartments: {ThematicDepartment}, Items: {Items.ToString()}";
        }
        public void ShowAllItems()
        {
            foreach (var item in Items) { Console.WriteLine(item.ToString()); }
        }
    }
}
