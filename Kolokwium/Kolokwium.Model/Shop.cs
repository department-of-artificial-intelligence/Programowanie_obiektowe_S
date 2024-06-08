using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Hide]
        public IList<Product> Products { get; set; }
        public string ProductsString => Products.Count > 0 ? string.Join(", ", Products) : "";
    }
}
