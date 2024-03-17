namespace PO.Lab3.Classes
{
    public interface IItemManagement
    {
        void ShowAllItems();
        Item FindItemBy(int id);
        Item FindItemBy(string ttl);
        Item? FindItem(Predicate<Item> match);
    }
}

