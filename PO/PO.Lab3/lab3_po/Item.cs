using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public abstract class Item
    {
        
        private string _title;
        private int _id;
        private string _publisher;
        private DateTime _dateOfIssue;

        protected int Id { get => _id; set => _id = value; }
        protected string Title { get => _title; set => _title = value; }
        protected string Publisher { get => _publisher; set => _publisher = value; }
        protected DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

        public Item()
        {
            _id = 0;
            _title = "";
            _publisher = "";
            _dateOfIssue = DateTime.Now;
        }

        public Item( string title, int id, string publisher, DateTime dateOfIssue)
        {
            Title = title;
            Id = id;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"id: {_id}, title: {_title}, publisher: {_publisher}, date of issue: {_dateOfIssue}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
    }

}
