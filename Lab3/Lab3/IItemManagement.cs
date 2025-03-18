using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IItemManagement
    {
        void ShowAllItems();
        Item FindItemBy(int id);
        Item FindItemById(string title);
        Item FindItem(Func<Item, bool> predicate);
    }
}
