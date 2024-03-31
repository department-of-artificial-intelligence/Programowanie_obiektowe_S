using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab03
{
    public interface IItemManagment
    {
        public void ShowAllItems();
        public Item FindItemById(int id);
        public Item FindItemByTitle(string title);
        public Item FindItem(<Func<Item, bool>>);
    }
}
