using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public interface IItemmanagement
    {
        void ShowAllItems();
        Item FindItemBy(int id);
        Item FindItemBy(string title);
        Item FindItem(Expression<Func<Item, bool>> predicate);
    }
}
