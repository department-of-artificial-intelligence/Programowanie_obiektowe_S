using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public class Journal : Item
    {
        public int Number { get; set; }

        public Journal() : base() { }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            var str = base.ToString(); ;
            str += $"Number: {Number}";
            return str;
        }

        public override string GenerateBarCode()
        {
            Random random = new Random();
            int barCodeLength = 13;
            string barCode = string.Empty;
            for (int i = 0; i < barCodeLength; i++)
            {
                barCode += random.Next(0, 10);
            }
            return barCode;
        }
    }
}

