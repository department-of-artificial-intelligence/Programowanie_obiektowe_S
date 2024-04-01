using System.Linq.Expressions;

namespace PO.Lab03
{
    internal class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }


        public Catalog(IList<Item> items)
        {
            Items = new List<Item>(items);
            ThematicDepartment = "brak";
        }

        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = new List<Item>(items);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        //Interface IItemManagemet
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

        public override string ToString()
        {
            string str = $"Catalog | ThematicDepartment: {ThematicDepartment} ";
            foreach (var item in Items)
            {
                str += $"\n{item}";
            }
            return str;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }

    }
}
