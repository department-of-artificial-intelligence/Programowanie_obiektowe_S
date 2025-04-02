using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium3
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateOfIssue { get { return _dateOfIssue; } set { _dateOfIssue = value; } }

        public Item( string title = "none", int id = -1, string publisher = "none", DateTime dateOfIssue = default(DateTime))
        {
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;

        }
        public override string ToString()
        {
            return $"id: {_id}, title: {_title}, publisher: {_publisher}, date of issue: {_dateOfIssue}";
        }
        public virtual void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();




    }
}