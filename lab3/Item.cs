using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal abstract class Item
    {
        private int _id;
        private string _title;
        private string _publisher;
        private DateTime _dateOfIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateOfIssue {  get { return _dateOfIssue; } set { _dateOfIssue = value; } }

        public Item() 
        { 
            _id = 0;
            _title = "nieznana";
            _publisher = "nieznany";
            _dateOfIssue = DateTime.MinValue;
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
            return $"Item | Id: {_id}, Title: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue} ";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
        public abstract string GenerateBarCode();
    }
}
