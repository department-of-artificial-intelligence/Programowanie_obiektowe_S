using Kolokwium.WpfApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Author
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set;} = null!;

        public string Email { get; set; } = null!;

        public DateTime DateOfBith {  get; set; } = DateTime.Now;

        [Hide]

        public IList<Book> Books { get; set; } = null!;

        public string BooksString => Books.Count > 0 ? string.Join(",", Books): "";

        public override string ToString()
        {
            return $"{FirstName} , {LastName}, {Email}";
        }

    }
}
