using Kolokwium.WpfApp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Genre { get; set; } = null!;

        public DateTime DateOfCreate { get; set; } = DateTime.Now;
        [Hide]
        public Author Author { get; set; } = null!;

        public string AuthorString => Author.FirstName;

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
