using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id
        {
            get { return _id; }
            set {  _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set {  _title = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public DateTime DateOfIssue
        {
            get { return _dateOfIssue;}
            set { _dateOfIssue = value;}
        }

        public Item()
        {
            _id = 0;
            _title = "nieznany";
            _publisher = "nieznany";
            _dateOfIssue = DateTime.Today;
        }

        public Item(string title, int id, string publisher, DateTime deteOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = deteOfIssue;
        }

        public override string ToString()
        {
            return $"Item: | Id: {Id}, Title: {Title}, Publisher: {Publisher}, DateOfIssue: {DateOfIssue}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public abstract string GenerateBarCode();
    }
}
