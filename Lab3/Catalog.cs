using System;
using System.Collections.Generic;

public class Catalog {
    public IList<Item> Items { get; set; } // Zmiana na IList<Item>
    public string ThematicDepartment { get; set; }

    // Konstruktor przyjmuje IList<Item> zamiast List<Item>
    public Catalog(string thematicDepartment, IList<Item> items) {
        ThematicDepartment = thematicDepartment;
        Items = items;
    }

    public void AddItem(Item item) {
        Items.Add(item);
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