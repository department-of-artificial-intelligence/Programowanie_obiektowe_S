using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    public interface IItemManagement {

        void ShowAllItems();

        Item FindItemBy(int id);
        Item FindItemBy(string title);

        Item FindItem(Predicate<Item> predicate);

    }
}
