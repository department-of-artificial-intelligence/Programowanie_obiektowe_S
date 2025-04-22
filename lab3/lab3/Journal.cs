using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal() : base()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
            : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"Journal " + base.ToString() + $"{Number} ";
        }
        public override string GenerateBarCode()
        {
            var rand = new Random();
            string kod = "";
            for (int i = 0; i < 8; ++i)
            {
                kod += rand.Next(0, 10);
            }
            return kod;

        }
    }
}

