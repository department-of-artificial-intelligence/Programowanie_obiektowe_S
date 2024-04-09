using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Zad2.Bll
{
    public interface IItemManagement
    {
        void ShowAllItems();
        Item FindItemBy(int id);
        Item FindItemBy(string title);
    }
}
