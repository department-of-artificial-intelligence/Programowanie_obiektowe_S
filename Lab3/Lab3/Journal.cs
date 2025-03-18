using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal : Item
    {
        public int Number { get; set;}
        public Journal()
        {
            Number = 0;
        }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) :base (title, id, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string GenerateBarCode()
        {
            string tmp = "";
            Random random = new Random();
            for (int i = 0; i < 13;i++)
            {
                tmp += random.Next(0, 10).ToString();
            }
            return tmp;
        }
    }
}
