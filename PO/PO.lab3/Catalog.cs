using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal class Catalog : IItemManagement
    {

        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }
        public Catalog() {

            Items = new List<Item>();
            ThematicDepartment = "none";

        
        }

        public Catalog(string thematicDepartment, IList<Item> items) { 
        
            ThematicDepartment = thematicDepartment;
            Items = items;
        
        }

        public void AddItem(Item item) { 
        
            Items.Add(item);
        
        }

        public Item FindItemBy(int id) { 
        
            return Items.FirstOrDefault(i => i.Id == id);
        
        }

        public Item FindItemBy(string title) {

            return Items.FirstOrDefault(i => i.Title == title);
        
        }

        public Item FindItem(Expression<Func<Item, bool>> expression) {


            return Items.FirstOrDefault(expression.Compile());
        
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Catalog:");
            sb.AppendLine($"ThematicDepartment: {ThematicDepartment}");

            foreach( var item in Items )
            {

                sb.AppendLine(item.ToString());
            }

            return sb.ToString();

        }

        public void ShowAllItems() {

            Console.WriteLine(ToString());

        }


    }
}
