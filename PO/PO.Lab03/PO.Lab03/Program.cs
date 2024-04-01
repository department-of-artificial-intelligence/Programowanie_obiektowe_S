using PO.Lab03;

Item item1 = new Journal("JAISCR", 1, "Springer", new DateTime(2000, 1, 1), 1);
Author author = new Author("Robert", "Cook", "Polish");
Item item2 = new Book("Agile C#", 2, "SPRINGER", new DateTime(2015, 1, 1), 500, new List<Author>() { author });
((Book)item2).AddAuthor(author);
var bookBarCode = ((Book)item2).GenerateBarCode();
var journalBarCode = ((Journal)item1).GenerateBarCode();
Console.WriteLine($"{item1} \r\n Barcode {journalBarCode}");
Console.WriteLine($"{item2} \r\n Barcode {bookBarCode}");

Console.WriteLine("=========\n");

IList<Item> items = new List<Item>();
items.Add(item1);
items.Add(item2);
Catalog catalog = new Catalog("IT C# development", items);
catalog.AddItem(new Journal("Neurocomputing", 1, "IEEE", new DateTime(2020, 1, 1), 1));
Console.WriteLine(catalog);
catalog.ShowAllItems();


//--- find position
string searchedValue = "Agile C#";
Item foundedItemById = catalog.FindItem(item => item.Id == 1);
Item foundedItemByTitle = catalog.FindItem(item => item.Title == searchedValue);
Item foundedItemByDateRange = catalog.FindItem(item => item.DateOfIssue >= new DateTime(2014, 12, 31) && item.DateOfIssue <= new DateTime(2015, 12, 31));
Console.WriteLine("++++++++++++++++++++++++++++++++++");
Console.WriteLine(foundedItemById);
Console.WriteLine(foundedItemByTitle);
Console.WriteLine(foundedItemByDateRange);
Item foundedItemByIdOld = catalog.FindItemBy(1);
Item foundedItemByTitleOld = catalog.FindItemBy(searchedValue);
Console.WriteLine("Found old way");
Console.WriteLine(foundedItemByIdOld);
Console.WriteLine(foundedItemByTitleOld);
Console.WriteLine("++++++++++++++++++++++++++++++++++");

Person librarian = new Librarian("John", "Kowalsky", DateTime.Now.Date, 2000);
Library library = new Library("Czestochowa, Armii Krajowej 36", new List<Librarian>(), new List<Catalog>());
library.AddLibrarian((Librarian)librarian);
library.ShowAllLibrarians();
Catalog catalog2 = new Catalog("Novels", new List<Item>());
library.AddCatalog(catalog2);
library.AddCatalog(catalog);
Item newItem = new Book("Song of Ice and Fire", 4, "Publisher", new DateTime(2011, 1, 1), 800, new List<Author>() { author });
library.AddItem(newItem, "Novels");
Console.WriteLine("======================");
Console.WriteLine(library);
Console.WriteLine("===========================All Items=======================\r\n");
library.ShowAllItems();

Console.WriteLine("===========================FIND BY=======================\r\n");
var foundedById = library.FindItemBy(4);
var foundedByTitle = library.FindItemBy(searchedValue);
var foundedByLambda = library.FindItem(x => x.Publisher == "Springer");
Console.WriteLine(foundedById);
Console.WriteLine(foundedByTitle);
Console.WriteLine(foundedByLambda);