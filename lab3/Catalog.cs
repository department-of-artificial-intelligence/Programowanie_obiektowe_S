using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    public class Catalog : IItemManagement {
        public IList<Item> Items { get; set; }
        public string ThematicDepartment { get; set; }

        public Catalog(IList<Item> items) {
            Items = items;
        }

        public Catalog(string thematicDepartment, IList<Item> items) {
            ThematicDepartment = thematicDepartment;
            Items = items;
        }

        public void AddItem(Item item) {
            this.Items.Add(item);
        }

        public override string ToString() {
            string napis = "";

            napis += $"ThematicDepartment: {this.ThematicDepartment}, Items:\n";

            foreach (Item item in this.Items) {
                napis += $"{item}\n";
            }

            return napis;
        }

        public void ShowAllItems() {
            string napis = "Items:\n";

            foreach (Item item in this.Items) {
                napis += $"{item}\n";
            }

            Console.WriteLine(napis);
        }

        public Item FindItemBy(int id) {
            return this.Items.FirstOrDefault(item => item.Id.Equals(id));
        }

        public Item FindItemBy(string name) {
            return this.Items.FirstOrDefault(item => item.Title.Equals(name));
        }

		public Item FindItem(Expression<Func<Item, bool>> predicate) {
			return Items.FirstOrDefault(predicate.Compile());
		}
	}
}
