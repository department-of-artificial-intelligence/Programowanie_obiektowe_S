using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Book : Item
    {



        public int PageCount
        {
            get; 
            set;
        }

        public override string GenerateBarCode()
        {
            return "Barcode";
        }
    }
}
