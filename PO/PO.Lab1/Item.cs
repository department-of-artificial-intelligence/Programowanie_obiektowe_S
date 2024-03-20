using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO.Lab1
{
    internal abstract class Item
    {
        private int _id;
        private string? _title;
        private string? _publisher;
        private DateTime _dateOfIssue;

        public int Id { get => _id; set => _id = value; }
        public string? Title { get => _title; set => _title = value; }
        public string? Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

        public Item()
        {
            _id = 0;
            _title = null;
            _publisher = null;
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
            return $"ID: {_id}, Title: {_title}, Publisher: {_publisher}, Date of isue: {_dateOfIssue}\n";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
        
    }
}
