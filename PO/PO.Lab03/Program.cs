using PO.Lab03;

public class Program
{
    static void Main(string[] args)
    {
        Item item1 = new Journal("JAISCR", 1, "Springer", new DateTime(2000, 1, 1), 1);
        Author author = new Author("Robert", "Cook", "Polish");
        Item item2 = new Book("Agile C#", 2, "SPRINGER", new DateTime(2015, 1, 1), 500,
        new List<Author>() { author });
        ((Book)item2).AddAuthor(author);
        var bookBarCode = ((Book)item2).GenerateBarCode();
        var journalBarCode = ((Journal)item1).GenerateBarCode();
        Console.WriteLine($"{item1} \r\n Barcode {journalBarCode}");
        Console.WriteLine($"{item2} \r\n Barcode {bookBarCode}");
        IList<Item> items = new List<Item>();
        items.Add(item1);
        items.Add(item2);
        Catalog catalog = new Catalog("IT C# development", items);
        catalog.AddItem(new Journal("Neurocomputing", 1, "IEEE", new DateTime(2020, 1, 1), 1));
        Console.WriteLine(catalog);
        catalog.ShowAllItems();
    }
}