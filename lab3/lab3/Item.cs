using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            string dateOfIssue = _dateOfIssue.ToString();
            return $"Issue: | Title: {_title}, Id: {_id}, Publisher: {_publisher}, Date of issue: {dateOfIssue}";
        }

        public virtual void Details()
        {
            Console.WriteLine(ToString());
        }

        public abstract string GenerateBarCode()
        {

        }
    }
}
