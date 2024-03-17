using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal()
        {
            Number = 0;
        }
        public Journal(string titel, int id, string publisher, DateTime timeOfIssue, int number) : base(id, titel, publisher, timeOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"Number: {Number} {base.ToString()} ";
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
