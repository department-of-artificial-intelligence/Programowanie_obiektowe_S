using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal interface ItemManagment 
    {
        void ShowAllItems();
        Item FindItemBy(int id);
        Item FindItemBy(string title);
        Item FindItem(Expression<Func<Item, bool>> predicate);

    }
}
