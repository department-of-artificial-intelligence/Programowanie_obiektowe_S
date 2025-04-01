using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    internal abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateOfIssue { get { return _dateOfIssue; } set { _dateOfIssue = value; } }

        public Item()
        {
            _id = 0;
            _title = "Brak";
            _publisher = "Brak";
            _dateOfIssue = DateTime.MinValue;
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"Item | Id: {_id}, Title: {_title}, Publisher, {_publisher}, " +
                   $"DateOfIssue, {_dateOfIssue}\n";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public abstract string GenerateBarCode();
    }
}
