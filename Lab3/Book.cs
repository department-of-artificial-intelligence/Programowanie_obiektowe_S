using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Book:Item
    {
        public int _pageCount;

        public IList<Author>? _authors;

        public int PageCount {  get { return _pageCount; } set { _pageCount = value; } 
                }

        public IList<Author> Authors
        {
            get { return _authors!; } 
            set { _authors = value; }
        }
             
        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount,IList<Author> authors) {
           
            Title = title;
            Id = id;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
            PageCount = pageCount;
            Authors = authors;
        }

        public override string ToString()
        {
            string temp=string.Empty;
            foreach (var item in Authors)
            {
                temp+=item;
                temp += "|";
            }
            return $"[{base.ToString()} ,PageCount={PageCount},Authors={temp}]";
        }

        public override string GenerateBarCode()
        {
            Random random = new Random();
            char[] array= "0123456789".ToCharArray();
            char[] code = new char[9];

            for (int i = 0; i < 9; ++i)
            {
                code[i] = array[random.Next(array.Length)];
            }

            string codeS = new string(code);
            return codeS;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }


    }
}
