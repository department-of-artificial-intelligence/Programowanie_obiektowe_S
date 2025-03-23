using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Journal : Item
    {
        public int Number
        {
            get;
            set;
        }

        public Journal() : base()
        {
            Number = 0;
        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            return "Journal: | " + base.ToString() + $" {Number}\n";
        }

        public override string GenerateBarCode()
        {
            int charLeft = 13; //chars in Bar code
            string charNumber = Id.ToString();
            charLeft -= charNumber.Length;
            charNumber = Number.ToString();
            charLeft -= charNumber.Length;
            charNumber = $"{Id}{Number}"; // using var. charNumber as return
            Random random = new Random();
            for (int i = 0; i < charLeft; ++i)
                charNumber += $"{random.Next(0, 9)}";
            return charNumber;
        }
    }
}
