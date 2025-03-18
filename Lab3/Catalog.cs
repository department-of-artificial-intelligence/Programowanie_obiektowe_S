using System;
using System.Collections.Generic;
using System.Linq;

public class Catalog {
    public IList<Item> Items { get; set; }
    public string ThematicDepartment { get; set; }

    public Catalog(string thematicDepartment, IList<Item> items) {
        ThematicDepartment = thematicDepartment;
        Items = items;
    }

    public void AddItem(Item item) {
        Items.Add(item);
    }

    public Item FindItem(Func<Item, bool> predicate) {
        return Items.FirstOrDefault(predicate);
    }

    public Item FindItemBy(int id) {
        return Items.FirstOrDefault(item => item.Id == id);
    }

    public Item FindItemBy(string title) {
        return Items.FirstOrDefault(item => item.Title == title);
    }

    public void ShowAllItems() {
        foreach (var item in Items) {
            Console.WriteLine(item);
        }
    }

    public override string ToString() {
        return $"Catalog: {ThematicDepartment}, Items Count: {Items.Count}";
    }
}