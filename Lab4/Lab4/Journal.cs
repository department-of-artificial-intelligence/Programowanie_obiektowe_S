using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Journal : Item
    {
        public int Number {  get; set; }
        public Journal():base()
        { 
            Number = 0;
        }

        public Journal( string title,int id, string publisher, DateTime dateOfIssue,int number): base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string ToString()
        {
            return base.ToString() + $", Number: {Number}";
        }

        public override string GenerateBarCode()
        {
            Random random = new Random();
            string barCode = "";

            for (int i = 0; i < 13; i++)
            {
                barCode += random.Next(0, 10).ToString(); 
            }

            return barCode;
        }
    }
}
