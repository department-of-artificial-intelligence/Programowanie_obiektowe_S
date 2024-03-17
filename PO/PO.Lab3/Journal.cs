using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal() : base()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return "Journal : " + base.ToString() + $" \\ {Number}";
        }
        public override string GenerateBarCode()
        {
            string res = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(33, 126);
                res += c;
            }
            return res;
        }
    }
}
