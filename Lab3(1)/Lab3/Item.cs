using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get => _id; set { _id = value; } }
        public string Title { get => _title; set { _title = value; } }
        public string Publisher { get => _publisher; set { _publisher = value; } }
        public DateTime DateOfIssue { get => _dateOfIssue; set { _dateOfIssue = value; } }

        public Item() {
            _id = 0;
            _title = string.Empty;
            _publisher = string.Empty;
            _dateOfIssue = DateTime.Today;
        }

        public Item( string title, int id, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"Id: {_id}, title: {_title}, publisher: {_publisher}, date of issue: {_dateOfIssue}";
        }

        public void Details()
        {
            Console.WriteLine( "Item" + ToString() );
        }

        public abstract string GenerateBarCode();
    }
}
