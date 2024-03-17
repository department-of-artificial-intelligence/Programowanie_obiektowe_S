using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public interface IItemManagement
    {
        void ShowAllItems();
        Item FindItemBy(int id);
        Item FindItemBy(string title);
        Item? FindItem(Predicate<Item> match);
    }
}
