using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
        [Hide]
        public IList<Book> Books { get; set; } = null!;
        public string AllBooks => Books.Count > 0 ? string.Join(' ', Books) : ""; 
    }
}
