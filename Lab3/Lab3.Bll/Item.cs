using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Bll
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get { return _id; } set { _id=value; } }
        public string Title { get { return _title; } set { _title=value; } }
        public string Publisher { get { return _publisher; } set { _publisher=value; } }
        public DateTime DateTime { get { return _dateOfIssue; } set { _dateOfIssue = value; } }
        public Item() { _id = 0; _title = string.Empty; _publisher = string.Empty; _dateOfIssue = DateTime.MinValue; }
        public Item(string title, int id, string publisher, DateTime date) {
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = date;
        }
        public override string ToString()
        {
            return $"Id: {_id}, Title: {_title}, Publisher: {_publisher}, Date: {_dateOfIssue} ";
        }
        public void Details() {
            Console.WriteLine(this.ToString());
        }
        public abstract string GenerateBarCode();
    }
}
