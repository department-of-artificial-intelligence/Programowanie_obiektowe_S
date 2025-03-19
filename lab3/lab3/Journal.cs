using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Journal : Item
    {
        public int Number { get; set; }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number) 
            : base(title, id, publisher, dateOfIssue)
        {
            _title = title;
            _id = id;
            _publisher = publisher; 
            _dateOfIssue = dateOfIssue;
            _number = number;
        }
        public override string ToString()
        {
            return base.ToString() + $" Number {_number}";
        }
        public override string GenerateBarCode()
        {
            
        }
    }
}
