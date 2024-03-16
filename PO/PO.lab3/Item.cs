using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.lab3
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

            public int Id
            {
                get { return _id; }
                set { _id = value; }
            }
            public string Title
            {
                get { return _title; }
                set { _title = value; }
            }
            public string Publisher
            {
                get { return _publisher; }
                set { _publisher = value; }
            }
            public DateTime DateOfIssue
            {
                get { return _dateOfIssue; }
                set { _dateOfIssue = value; }
            }
            public Item()
            {
                _id = 0;
                _title = string.Empty;
                _publisher = string.Empty;
                _dateOfIssue = DateTime.MinValue;
            }
            public Item(int id, string title, string publisher, DateTime dateOfIssue)
            {
                _id = id;
                _title = title;
                _publisher = publisher;
                _dateOfIssue = dateOfIssue;
            }
            public override string ToString()
            {
                return $"id: {_id}, title: {_title}, publisher: {_publisher}, dateOfIssue: {_dateOfIssue} " + '\n';
            }
            public void Details()
            {
                Console.WriteLine(this.ToString());
            }
            public abstract string GenerateBarCode();
    }
}
