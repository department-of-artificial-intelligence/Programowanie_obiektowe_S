using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Library : IItemManagement
    {
        public string Address {  get; set; }
        public IList<Librarian> Librarians { get; set; }

    }
}
