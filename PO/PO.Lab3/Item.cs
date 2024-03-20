using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_po
{
    public abstract class Item
    {

        protected string _title;
        protected int _id;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

        public Item()
        {
            _id = 0;
            _title = "";
            _publisher = "";
            _dateOfIssue = DateTime.Now;
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
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
