namespace Lab3
{
    /*
     * TODO:
     * Item: DONE
     * Catalog 1.0: DONE
     * Journal: DONE
     * Book: DONE
     * Author 1.0: DONE
     * 
     * Person: DONE
     * Author 2.0: DONE
     * Librarian:
     * ItemManagement: DONE
     * Catalog 2.0: DONE
     * Library:
     * 
     * Figure out the barcode function: MAKE RANDOM 13 NUMBERS AS A STRING TODOOOO
     * 
     * can FindItem take Predicate<Item> instead of Expression<Func<Item, bool>> as an argument because it works this way and doesn't the other
     * 
     * 
     */


    internal class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Journal(1, "JAISCR", "Springer", new DateTime(2000, 1, 1), 1);
            Author author = new Author("Robert", "Cook", "Polish");
            Item item2 = new Book(2, "Agile C#", "SPRINGER", new DateTime(2015, 1, 1), 500,
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
            catalog.AddItem(new Journal(1, "Neurocomputing", "IEEE", new DateTime(2020, 1, 1), 1));
            Console.WriteLine(catalog);
            catalog.ShowAllItems();
        }
    }
}
