using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal(int id, string title, string publisher, DateTime dateTime, int number) 
            : base(id, title, publisher, dateTime)
        {
            Number = number;
        }
        public override string GenerateBarCode()
        {
            var codeLength = 12;
            var rnd = new Random();
            string code = "JR";
            var min = (int)'a';
            var max = (int)'z';
            for(int i = 0; i < codeLength; i++)
            {
                code += (char)rnd.Next(min, max);
            }
            return code;
        }
        public override string ToString()
        {
            return $"{base.ToString()} {Number}";
        }
    }
}
