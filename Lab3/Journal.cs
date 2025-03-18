using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number): base(id, title, publisher, dateOfIssue) { Number = number; }
        public Journal() : base() { Number = 0; }
        public override string ToString()
        {
            return base.ToString()+$", Number: {Number}";
        }
        public override string GenerateBarCode()
        {
            Random rnd = new Random();
            return rnd.Next(1000000, 9999999).ToString() + rnd.Next(0, 9999999).ToString();
        }

    }
}
