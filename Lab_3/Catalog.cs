namespace Lab_3
{
    internal class Catalog
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
    }

}
