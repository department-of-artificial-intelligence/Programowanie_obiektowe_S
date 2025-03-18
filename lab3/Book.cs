using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    public class Book : Item {

        public int PageCount { get; set; }

        public IList<Author> Authors { get; set; }

        public Book() {
        }

        public Book(string title, int id, string publisher, DateTime dateOfIssue, int pageCount, IList<Author> authors) : base(title, id, publisher, dateOfIssue) {
            Title = title;
            Id = id;
            PageCount = pageCount;
            Authors = authors;
        }

        public override string GenerateBarCode() {
            string napis = "";
            for (int i = 0; i < 14; i++) {
                Random random = new Random();
                napis += random.Next(10);
            }
            return napis;
        }

        public void AddAuthor(Author author) {
            this.Authors.Add(author);
        }

        public override string ToString() {
            string napis = base.ToString();

            napis += $" Page Count:{this.PageCount}, " +
                     $"Authors:\n";

            foreach (Author author in this.Authors) {
                napis += author + "\n";
            }

            return napis;
        }

    }
}
