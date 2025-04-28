namespace Lab3
{
    public class Catalog : IItemManagement
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set;}

        public Catalog(IList<Item> items) {
            Items = items;
            ThematicDepartment = "Nieznany";
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

        public override string ToString()
        {
            string temp = $"ThematicDepartment:{ThematicDepartment}";
            if (Items != null)
            {
                temp += ", Przedmioty:";
                foreach (Item item in Items)
                {
                    temp += $"\n\t{item}";
                }
            }
            return temp;
        }

        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item);
            }
        }

        public Item FindItemBy(int id)
        {
            foreach (Item item in Items)
                if (item.Id == id)
                    return item;
            return null!;
        }

        public Item FindItemBy(string title)
        {
            foreach (Item item in Items)
                if (item.Title == title)
                    return item;
            return null!;
        }


        public Item FindItem(Predicate<Item> predicate)
        {
            foreach (Item item in Items)
                if (predicate(item))
                    return item;
            return null!;
        }
    }
}
