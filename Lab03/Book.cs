using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Lab03
{
    public class Book
    {
        public Book() { }
        public Book(int id) { }
        public Book(int id, string name)
        {

        }
        public int PageCount { get; set; }
        public IList<Author> Authors { get; set; }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : this(pageCount)
        {
            
        }
        public string ToString()
        {
            //return $"Id: {_id}, Title: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue}";
        }

        public string GenerateBarCode()
        {
            //return $"Id: {_id}, Title: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue}";
        }

    }
}
