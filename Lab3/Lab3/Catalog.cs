namespace Lab3
{
    public class Catalog : Item
    {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(IList<Item> items)
        {
            this.Items = items;
        }
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            this.ThematicDepartment = thematicDepartment;
            this.Items = items;
        }

        public override string ToString()
        {
            return $"Catalog | {base.ToString()}, items = {Items}, thematicDepartment = {ThematicDepartment}";
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void ShowAllItems() {
            Console.WriteLine(this.Items);
        }
    }
}
