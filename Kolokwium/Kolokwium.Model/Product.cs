using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [Hide]
        public Shop Shop { get; set; } = null!;
        public string ShopString=>Shop.Name;
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
