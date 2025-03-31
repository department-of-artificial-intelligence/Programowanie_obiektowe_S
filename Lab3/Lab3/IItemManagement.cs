using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IItemManagement
    {
        void ShowAllItems();
        Item FindItemBy(int id);
        Item FindItemBy(string title);
        Item FindItem(Expression<Func<Item, bool>> predicate);
    }
}
