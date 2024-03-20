using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PO.Lab03
{
    internal class Journal : Item
    {
        public int Number {  get; set; }

        public Journal() : base()
        { 
            Number = 0;
        }

        public Journal(int id, string title, string publisher, DateTime dateOfIssue, int number) 
            : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            return $"Journal | {base.ToString()}, Number: {Number}";
        }

        public override string GenerateBarCode()
        {
            return "12345678";
        }
    }
}
