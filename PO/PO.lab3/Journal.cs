using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Journal : Item
    {
        public int Number
        {
            get; set;
        }
        public Journal()
        : base()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string GenerateBarCode()
        {
            string str = "";
            Random random = new Random();
            for (int i = 0; i < 13; i++)
            {
                char c = (char)random.Next(0, 78);
                str += c;
            }
            return str;
        }


    }
}
