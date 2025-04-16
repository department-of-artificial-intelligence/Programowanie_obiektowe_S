using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IItemManagment
    {
        public void ShowAllItems();
        public Item FindItemBy(int id);
        public Item FindItemBy(string id);
        public Item FindItem(Expression<Func<Item, bool>> predicate);
    }
}
