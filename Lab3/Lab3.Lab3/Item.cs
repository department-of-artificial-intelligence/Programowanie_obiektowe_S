using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Lab3
{
    public abstract class Item
    {
        private int _id;
        private string _title;
        private string _publisher;
        private DateTime _dateOfIssue;

        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Publisher { get => _publisher; set => _publisher = value; }
        public DateTime DateOfIssue { get => _dateOfIssue; set => _dateOfIssue = value; }

        public Item()
        {
            _id = 0;
            _title = string.Empty;
            _publisher = string.Empty;
            _dateOfIssue = DateTime.MinValue;
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, Publisher: {Publisher}, DateOfIssue: {DateOfIssue}";
        }

        public void Details() { Console.WriteLine(ToString());  }

        public abstract string GenerateBarCode();
    }
}
