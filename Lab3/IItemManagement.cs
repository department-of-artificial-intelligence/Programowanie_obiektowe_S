using System;
using System.Collections.Generic;

public interface IItemManagement {
    void AddItem(Item item, string thematicDepartment);
    Item FindItemBy(int id);
    Item FindItemBy(string title);
    Item FindItem(Func<Item, bool> predicate);
    void ShowAllItems();
}