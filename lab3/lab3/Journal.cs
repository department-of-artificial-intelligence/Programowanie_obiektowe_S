using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Journal :Item
    {
        protected int _number;

        public int Number { get { return _number; } set { _number = value; } }
                
        public Journal() { }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number):base(title,id,publisher,dateOfIssue)
        {
            Number = number;
            
        }

        public override string ToString()
        {

            return $"Id={Id},Title={Title},Publisher={Publisher},DateOfIssue={DateOfIssue},Number={Number}";


        }

        public override string GenerateBarCode()
        {
            return $"J{Id}";
        }
    }
}
