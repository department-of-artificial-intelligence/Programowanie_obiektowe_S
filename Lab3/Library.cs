using System;
using System.Collections.Generic;
using System.Linq;

public class Library : IItemManagement {
    public string Address { get; set; }
    public IList<Librarian> Librarians { get; set; }
    public IList<Catalog> Catalogs { get; set; }

    public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs) {
        Address = address;
        Librarians = librarians;
        Catalogs = catalogs;
    }

    public void AddLibrarian(Librarian librarian) {
        Librarians.Add(librarian);
    }

    public void AddCatalog(Catalog catalog) {
        Catalogs.Add(catalog);
    }

    public void AddItem(Item item, string thematicDepartment) {
        var catalog = Catalogs.FirstOrDefault(c => c.ThematicDepartment == thematicDepartment);
        catalog?.AddItem(item);
    }

    public Item FindItemBy(int id) {
        foreach (var catalog in Catalogs) {
            var item = catalog.FindItemBy(id);
            if (item != null) return item;
        }
        return null;
    }

    public Item FindItemBy(string title) {
        foreach (var catalog in Catalogs) {
            var item = catalog.FindItemBy(title);
            if (item != null) return item;
        }
        return null;
    }

    public Item FindItem(Func<Item, bool> predicate) {
        foreach (var catalog in Catalogs) {
            var item = catalog.FindItem(predicate);
            if (item != null) return item;
        }
        return null;
    }

    public void ShowAllItems() {
        foreach (var catalog in Catalogs) {
            catalog.ShowAllItems();
        }
    }

    public void ShowAllLibrarians() {
        foreach (var librarian in Librarians) {
            Console.WriteLine(librarian);
        }
    }

    public override string ToString() {
        return $"Library: {Address}, Librarians: {Librarians.Count}, Catalogs: {Catalogs.Count}";
    }
}