using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kol
{
    public class Jednostka
    {
        public string Nazwa { get; set; } = "";

        public override string ToString()
        {
            return Nazwa;
        }
    }
}
