using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;

        public Library Library { get; set; } = null!;
        public int LibraryId { get; set; } 
        public override string ToString()
        {
            return $"{Title},";
        }
    }
}
