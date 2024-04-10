using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Przygotowanie_Full
{
    internal class Journal : Item
    {

        public int Number { get; set; }
        public Journal() { 
        
            Number = 0;
        
        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) 
            : base(title, id, publisher, dateOfIssue) { 
        
            Number = number;
        }

        public override string ToString()
        {

            return $"Journal | {base.ToString()} Number {Number}";

        }

    }
}
