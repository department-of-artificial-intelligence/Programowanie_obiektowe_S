using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Journal: Item
    {
        public int Number {  get; set; }
        public Journal(int id = -1, string title = "none", string publisher = "none", DateTime dateOfIssue = default(DateTime), int number = -1)
            :base(id, title, publisher, dateOfIssue)
        {
            Number = number;
        }
        public override string ToString()
        {
            return $"id: {_id}, title: {_title}, publisher: {_publisher}, date of issue: {_dateOfIssue}, number: {Number}";
        }
        public override string GenerateBarCode()
        {
            //losowa generacja kodu kreskowego
            return "Journal BarCode";
        }
    }
}
