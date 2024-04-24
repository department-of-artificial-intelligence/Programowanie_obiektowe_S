using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lab03.BLL
{
    public interface ItemManagment
    {
        public abstract void ShowAllItems();
        public abstract Item FindItemBy(int id);
        public abstract Item FindItemBy(string title);
        public abstract Item FindItem(Expression<Func<Item, bool>> predicate);

    }
}
