namespace Lab_3
{
    internal class Catalog
    {
        public IList<Item> Items { get; set; } = new List<Item>();
        public string ThematicDepartment { get; set; }
        public Catalog(IList<Item> items, string thematicDepartment)
        {
            Items = items;
            ThematicDepartment = thematicDepartment;
        }

    }

}
