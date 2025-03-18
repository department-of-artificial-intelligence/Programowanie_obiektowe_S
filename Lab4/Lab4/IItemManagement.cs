using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public interface IItemManagement
    {
        public void ShowAllItems();
        public Item FindItemBy(int id);
        public Item FindItemBy(string title);
        public Item FindItem(Predicate<Item> predicate);
    }
}
