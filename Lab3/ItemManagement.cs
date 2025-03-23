using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface ItemManagement
    {
        public void ShowAllItems();
        public Item FindItemBy(int id);
        public Item FindItemBy(string title);
        public Item FindItem(Func<Item, bool> predicate);
    }
}
