using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Catalog
    {
        public IList<Item> Items { get; set; }

        public string ThematicDepatment {  get; set; }

    //    public Catalog(IList<Item> items) { }

        public Catalog(string thematicDepatment, IList<Item> items)
        {
            ThematicDepatment = thematicDepatment;
            Items = items ?? new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }


        public override string ToString() {
            return $"catalog: {ThematicDepatment}, ilosc {Items.Count}.";
        }

        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                Console.WriteLine(item.ToString());
            }
        }


    }
}
