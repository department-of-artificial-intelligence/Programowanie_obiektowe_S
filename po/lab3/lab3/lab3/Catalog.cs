    
namespace lab3
{
    using System;
    internal class Catalog
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

        public override string ToString()
        {
            string items = "";
            foreach (var item in Items)
            {
                items += $"\n{item}";
            }
            return $"Catalog | ThematicDepartment: {ThematicDepartment}" + items;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

    }
}
