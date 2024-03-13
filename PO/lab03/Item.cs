using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public abstract class Item
    {
        protected int _id;
        protected string _title, _publisher;
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
        public Item(int id, string title, string publisher, DateTime dateTime)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateTime;
        }
        public override string ToString()
        {
            return $"{Id}; {Title}; {Publisher}; {DateOfIssue}";
        }
        public abstract string GenerateBarCode();
    }
}
