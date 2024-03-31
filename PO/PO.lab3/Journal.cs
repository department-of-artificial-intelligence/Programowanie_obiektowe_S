using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    internal class Journal : Item
    {
        public int Number { get; set; }
        public Journal() { }
        public Journal(string title, int id, string publisher, DateTime dateOfIssue, int number)
        {
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
            Number = number;
        }
        public override string ToString()
        {
            return $"JOURNAL |  ID {_id} Title {_title} Publisher {_publisher} Date Of Issue {_dateOfIssue} Number {Number}";
        }
        public string GenerateBarCode()
        {
            return "journal1111";
        }
    }
}
