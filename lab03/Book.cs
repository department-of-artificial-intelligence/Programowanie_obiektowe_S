using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Book:Item
    {
        public int PageCount {  get; set; }

        public IList<Author> AuthorList { get; set; }

        public Book(string title, int id, string publisher, DateTime DateOfIssue, int pageCount, IList<Author> authors):base(title, id, publisher, DateOfIssue)
        {
            PageCount=pageCount;
            AuthorList=authors;
        }


        public override string ToString()
        {
            return $"id: {_id}, tytul: {_title}, wydawnictwo: {_publisher}, data wydania: {_dateOfIssue}, strony: {PageCount}.";
        }

        public void AddAuthor(Author author) {
            AuthorList.Add(author);
        
        }

        public override string GenerateBarCode()
        {
            string barcode = "";

            Random rand = new Random();

            for (int i = 0; i < 13; i++)
            {
                long liczba = rand.Next(0, 10);
                string liczba2 = liczba.ToString();
                barcode = barcode + liczba2;

            }

            return barcode;
        }
    }
}
