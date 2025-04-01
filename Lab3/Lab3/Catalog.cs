using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Catalog:IItemManagement
    {
        public IList<Item> Items=new List<Item>();
        public string ThematicDepartment {  get; set; }
        public Catalog(IList<Item> items)
        {
            ThematicDepartment = "nieznanytemat";
            Items = items;
        }
        public Catalog(string thematicDepartment, IList<Item> items)
        {
            ThematicDepartment=thematicDepartment;
            Items = items;
        }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public override string ToString()
        {
            return $"THEMATIC DEPARMENT: {ThematicDepartment} ";
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
            var item = Items.FirstOrDefault(b => b.Id == id);
            if (item == null)
                throw new Exception($"Nie znaleziono przedmiotu o ID: {id}");
            return item;
        }

        public Item FindItemBy(string title)
        {
            var item = Items.FirstOrDefault(b => b.Title == title);
            if (item == null)
                throw new Exception($"Nie znaleziono przedmiotu o tytule: \"{title}\"");
            return item;
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            var item = Items.AsQueryable().FirstOrDefault(predicate);
            if (item == null)
                throw new Exception("Nie znaleziono przedmiotu spełniającego podany warunek.");
            return item;
        }



    }
}
