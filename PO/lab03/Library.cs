using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab03
{
    public class Library
    {
        public string Address { get; set; }
        public IList <Librarian> Librarians { get; set; }

    }
}
