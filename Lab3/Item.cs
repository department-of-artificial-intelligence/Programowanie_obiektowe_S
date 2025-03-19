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
        protected string? _title;
        protected string? _publisher;
        protected DateTime _dateOfIssue;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string? Title
        {
            get => _title;
            set => _title = value ?? "No Title";
        }

        public string? Publisher
        {
            get => _publisher;
            set => _publisher = value ?? "No Publisher";
        }

        public DateTime DateOfIssue
        {
            get => _dateOfIssue;
            set => _dateOfIssue = value;
        }

        public Item()
        {
            Id = 0;
            Title = "No Title";
            Publisher = "No Publisher";
            DateOfIssue = default;
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            Id = id;
            Title = title ?? "No Title";  
            Publisher = publisher ?? "No Publisher";
            DateOfIssue = dateOfIssue;
        }

        public override string ToString() => $"{Id} {Title} {Publisher} {DateOfIssue.ToShortDateString()}";

        public virtual void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
    }
}
