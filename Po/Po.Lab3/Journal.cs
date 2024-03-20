using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab3
{
    internal class Journal : Item
    {
        public int Number { get; set; }
        public Journal() { 
            Number = 0;
        }
        public Journal(string title, int id,
            string publisher,DateTime dateOfIssue,int number) : 
            base(title,id,publisher,dateOfIssue) { 
            Number = number;
        }
        public override string ToString()
        {
            return base.ToString()+$", Number:{Number}";
        }

        public override string GenerateBarCode()
        {
            var rand = new Random();
            string rand1="";
            for(int i=0;i<8;i++)
            { 
                rand1+=rand.Next().ToString();
            }
            return rand1;
        }
    }
}
