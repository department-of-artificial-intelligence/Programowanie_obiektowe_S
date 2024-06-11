using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium.Model
{
    public class Park
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Area { get; set; }
        public IList<Tree> Trees { get; set; } = null!;
        public string AllTrees => Trees.Count > 0 ? string.Join(", ", Trees) : "";
    }
}
