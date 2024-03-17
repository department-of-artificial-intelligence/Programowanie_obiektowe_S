using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Library
    {
        public string Adress {  get; set; }
        public IList<Librarian> Librarians { get; set;}
        public IList<Catalog> Catalogs {  get; set; }
        public Library(string adress, IList<Librarian> librarians, IList<Catalog> catalogs) 
        {
            Adress = adress;
            Librarians = librarians;
            Catalogs = catalogs;
        }
        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }
        public void ShowAllLibrarians()
        {
            foreach (Librarian librarian in Librarians)
            {
                Console.WriteLine(librarian.ToString());
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddItem(Item item, string thematicDepartment)
        {
            Catalogs.First(catalog=>catalog.ThematicDepartment==thematicDepartment).AddItem(item);
        }
        public void ShowAllItems()
        {
            foreach (Item item in Catalogs)
            {
                Console.WriteLine(Catalogs.ToString());
            }
        }
        public Item FindItemBy(int id)
        {
            foreach (Catalog catalog in Catalogs)
            {
                return catalog.FindItemBy(id);
            }
            return default;
        }
        public Item FindItemBy(string titel)
        {
            foreach (Catalog catalog in Catalogs)
            {
                return catalog.FindItemBy(titel);
            }
            return default;
        } 
        public Item? FindItem(Predicate<Item> match)
        {
            foreach (Catalog catalog in Catalogs)
            {
                return catalog.FindItem(match);
            }
            return default;
        }
        public override string ToString()
        {
            foreach (Librarian librarian in Librarians)
            {
                if (librarian != null)
                {
                    Console.WriteLine(librarian.ToString());
                }
            }
            foreach (Catalog catalog in Catalogs)
            {
                if (catalog != null)
                {
                    Console.WriteLine(catalog.ToString());
                }
            }
            return $"Adress: {Adress}";
        }
    }
}
