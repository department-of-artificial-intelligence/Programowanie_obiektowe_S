using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
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
            Id = 0;
            Title = "none";
            Publisher = "none";
            DateOfIssue = DateTime.MinValue;
        }
        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            Id= id;
            Title= title;
            Publisher= publisher;
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"Item | Id: {_id}, Title: {_title}, Publisher: {_publisher}, Date of issue: {_dateOfIssue} \n";
        }
        public virtual void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
        
    }
}
