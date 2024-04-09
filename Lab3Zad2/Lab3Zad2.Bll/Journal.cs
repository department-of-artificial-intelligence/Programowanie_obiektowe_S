using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Zad2.Bll
{
    public class Journal : Item
    {

        public int Number { get; set; }
        public Journal() { }
        public Journal(int id, string title, string publisher, DateTime dateOfIssue, int number)
            : base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            Console.Write(base.ToString() + "\n");
            return $" Number: {Number}";
        }

        public override string GenerateBarCode()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
