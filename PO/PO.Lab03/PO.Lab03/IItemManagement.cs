using System.Linq.Expressions;

namespace PO.Lab03
{
    internal interface IItemManagement
    {
        public void ShowAllItems();
        public Item FindItemBy(int id);
        public Item FindItemBy(string title);
        public Item FindItem(Expression<Func<Item, bool>> predicate);
    }
}
