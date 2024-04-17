using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace lab3
{
    internal interface ItemManagement
    {
        public void ShowAllItems();
        public Item? FindItemBy(int id);
        public Item? FindItemBy(string id);
        public Item? FindItem(Expression<Func<Item, bool>> expression);
    }
}
