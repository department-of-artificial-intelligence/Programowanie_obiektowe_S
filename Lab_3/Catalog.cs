using System.Linq.Expressions;

namespace Lab_3
{
    public class Catalog : ItemManagement
    {
        public IList<Item> Items { get; set; } = new List<Item>();
        public string ThematicDepartment { get; set; }
        public Catalog( string thematicDepartment, IList<Item> items)
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
            return $"ThematicDepartment: {ThematicDepartment},{string.Join("\n", Items)}";
        }
        public void ShowAllItems()
        {
            Console.WriteLine(string.Join("\n",Items));
        }
        public Item FindItemBy(int id)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if(id == Items[i].Id)
                {
                    return Items[i];
                }
            }
            return null;
        }
        public Item FindItemBy(string title)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (title == Items[i].Title)
                {
                    return Items[i];
                }
            }
            return null;
        }
        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (predicate.Compile()(Items[i]))
                {
                    return Items[i];
                }
            }
            return null;
        }

    }

}
