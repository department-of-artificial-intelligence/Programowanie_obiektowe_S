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

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }

        public DateTime DateOfIssue
        {
            get => _dateOfIssue;
            set => _dateOfIssue = value;
        }

        public Item()
        {
            _id = 0;
            _title = "none";
            _publisher = "none";
            _dateOfIssue = default;
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue)
        {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
        }

        public override string ToString() => $"{Id} {Title} {Publisher} {DateOfIssue}";

        public virtual void Details()
        {
            Console.WriteLine(this);
        }

        public abstract string GenerateBarCode();
    }
}
