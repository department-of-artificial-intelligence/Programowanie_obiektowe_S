using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal( string title = "none", int id = -1, string publisher = "none", DateTime dateOfIssue = default(DateTime), int number = -1)
            : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, number: {Number}";
        }

        public override string GenerateBarCode()
        {
            //losowa generacja kodu kreskowego
            Random random = new Random();
            string res = "";

            for (int i = 0; i < 13; i++)
            {
                res += random.Next(1, 10);
            }
            return res;
        }

    }
}