using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int ID {
            get { return _id; }
            set { _id = value; }
        }
        public string Title {
            get { return _title; }
            set { _title = value; }
        }

        public string Publisher {
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
            _title = "brak";
            _publisher = "brak";
            _dateOfIssue = DateTime.Now;
        }
        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"Item | id {_id}, title {_title}, publisher {_publisher}, DateOfIssue {_dateOfIssue}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
    }
}
