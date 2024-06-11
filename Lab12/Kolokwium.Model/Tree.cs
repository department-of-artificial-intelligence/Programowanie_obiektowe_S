using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public double Raduis { get; set; }
        public Park Park { get; set; } = null!;
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
