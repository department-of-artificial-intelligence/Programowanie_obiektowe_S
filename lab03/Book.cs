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

            Random random= new Random();
            string number=random.Next(1,9).ToString();
            for(int i = 0; i < 12; i++)
            {
                number += random.Next(0,9);
            }

            number = barcode;

            return barcode;
        }
    }
}
