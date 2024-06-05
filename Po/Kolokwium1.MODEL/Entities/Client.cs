using Kolokwium1.MODEL;
using Kolokwium1.MODEL.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1.MODEL.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        [Hide]
        public IList<Book> Books { get; set; } = null!; //właściwość nawigacyjna
        public string AllBooks => Books.Count > 0 ? string.Join(", ", Books) : "";

        public override string ToString()
        {
            return FirstName.ToString(CultureInfo.InvariantCulture);
        }
    }
}
