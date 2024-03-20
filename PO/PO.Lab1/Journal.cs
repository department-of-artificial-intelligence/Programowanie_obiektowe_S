using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
    internal class Journal:Item
    {
        public int Number {  get; set; }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) :base(id, title, publisher, dateOfIssue) { 
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string GenerateBarCode()
        {
            var rand = new Random();
            string rand1 = "";
            for (int i = 0; i < 1; i++)
            {
                rand1 += rand.Next().ToString();
            }
            return rand1;
        }
    }
}
