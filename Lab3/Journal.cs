using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }

        public Journal() : base("Unk.title", 0, "Unk. Publisher", DateTime.MinValue)
        {
            Number = 0;
        }

        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
            : base(title, id, publisher, dateOfIssue)
        {
            Number = number;
        }

        public override string GenerateBarCode()
        {
            Random rand = new Random();
            string text = "";

            for (int i = 0; i < 13; i++)
            {
                text += rand.Next(0, 10); // Generuje losową cyfrę od 0 do 9
            }
            return text;
        }

        public override string ToString()
        {
            return base.ToString() + $", Issue Number: {Number}";
        }
    }
}
