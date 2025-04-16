using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Journal : Item
    {
        public int Number { get; set; }

        public Journal()
        {
            Number = 0;
        }

        public Journal(string title, int number, string publisher, DateTime dateOfIssue, int id) : base(title, id, publisher, dateOfIssue) 
        {
            Number = number;
        }

		public override string ToString()
		{
			return $"Journal number: {Number}\n" + base.ToString();
		}

        public override string GenerateBarCode() 
        {
            return "JBC";
        }
	}
}
