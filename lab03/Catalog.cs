using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Catalog: IItemMenagment
    {
        public IList<Item> Items { get; set; }

        public string ThematicDepartment {  get; set; }

    //    public Catalog(IList<Item> items) { }

        public Catalog(string thematicDepatment, IList<Item> items)
        {
            ThematicDepartment = thematicDepatment;
            Items = items ?? new List<Item>();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }



        public Item FindItem(Expression<Func<Item, bool>> predicate) {
            return Items.AsQueryable().FirstOrDefault(predicate);
        }

        public Item FindItemBy(string title) {
            return Items.FirstOrDefault(item => item.Title == title );
        }

        public Item FindItemBy(int id) {

            return Items.FirstOrDefault(item => item.Id == id);

        }


        public override string ToString() {
            return $"catalog: {ThematicDepartment}, ilosc {Items.Count}.";
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
