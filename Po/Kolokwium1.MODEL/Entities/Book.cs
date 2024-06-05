using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium1.MODEL.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; } = null!;
        public DateTime DataWydania { get; set; }
        public double Cost { get; set; }
        public Client CClient { get; set; } = null!;

        public override string ToString()
        {
            return Id.ToString(CultureInfo.InvariantCulture);
        }


    }
}
