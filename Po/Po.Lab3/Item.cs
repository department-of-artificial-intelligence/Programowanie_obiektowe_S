using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Po.Lab3
{
    internal abstract class Item
    {
        private int _id;
        private string? _title;
        private string? _publisher;
        private DateTime? _dateOfIssue;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => (DateTime)_dateOfIssue; set => _dateOfIssue = value; }

        public Item()
        { 
            _id = 0;
            _title = null;
            _publisher = null;
            _dateOfIssue = null;
        }
        public Item(string title, int id, string publisher, DateTime dateofIssue)
        { 
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateofIssue;
        }
        public override string ToString()
        {
            return $"id: {_id}, title: {_title}, publisher: {_publisher}, Date of issues: {_dateOfIssue}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public abstract string GenerateBarCode();
    }
}
