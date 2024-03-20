using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }

        public Journal(): base() { Number = 0; }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
            : base(title, id, publisher, dateOfIssue)
        { 
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString() + $" , Number: {Number}";
        }

        public override string GenerateBarCode()
        {
            string output = string.Empty;
            Random rng = new Random();
            for (int i = 0; i < 13; i++)
            {
                int a = rng.Next(11,36);
                if (a <= 10) output += (char)(a + 47);
                else output += (char)(a + 86);
            }
            return output;
        }
    }
}
