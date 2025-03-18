using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Journal:Item
    {
        public int Number {  get; set; }
        public Journal():base() {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return base.ToString() + $", Number: {Number}";
        }

        public override string GenerateBarCode()
        {
            string res = "";
            Random rand = new Random();
            for (int i = 0; i < 13;++i)
            {
                res += Convert.ToString(rand.Next(0, 10)) ;
            }
            return res;
        }
    }
}
