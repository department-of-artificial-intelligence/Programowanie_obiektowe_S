using System.Linq.Expressions;

namespace PO.Lab3.Classes
{
    public class Catalog
    {
        IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items)
        {
            Items = items;
        }
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment = thematicDepartment;
            Items = items;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public Item? FindItem(Predicate<Item> match)
        {
            foreach (Item item in Items)
            {
                if (match(item))
                    return item;
            }
            return default;
        }

        public Item? FindItemBy(string title)
        {
            return Items.FirstOrDefault(x => x.Title == title);
        }

        public Item FindItemBy(int id)
        {
            return Items.First(x=>x.Id == id);
        }
        public override string ToString()
        {
            string str = string.Empty;
            foreach (Item item in Items)
            {

                str += item.ToString();
            }
            return str + ThematicDepartment;
        }

        public void ShowAllItems()
        {
            Console.WriteLine(this);
        }


    }

}

