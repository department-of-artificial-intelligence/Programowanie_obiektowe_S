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

        public int Id
        {
            get => _id;
            set => _id = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value ?? "no defined";
        }
        public string Publisher
        {
            get => _publisher;
            set => _publisher = value ?? "no defined";
        }
        public DateTime DateOfIssue
        {
            get => _dateOfIssue;
            set => _dateOfIssue = value;
        }

        public Item()
        {
            Title = "no defined";
            Id = 0;
            Publisher = "no defined";
            DateOfIssue = DateTime.MinValue;
        }

        public Item(string? title, int id, string? publisher, DateTime dateOfIssue)
        {
            Title = title ?? "no defined";
            Id = id;
            Publisher = publisher ?? "no defined";
            DateOfIssue = dateOfIssue;
        }

        public override string ToString()
        {
            string SDate = DateOfIssue.ToString("dd-MM-yyyy");
            return $"{Title}, {Id}, {Publisher}, {SDate} ";
        }
        public void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();


    }
}
