using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Zad2.Bll
{
    public abstract class Item
    {
        protected int _id;
        protected string _title;
        protected string _publihser;
        protected DateTime _dateOfIssue;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Publisher
        {
            get { return _publihser; }
            set { _publihser = value; }
        }
        public DateTime DateOfIssue
        {
            get { return _dateOfIssue; }
            set { _dateOfIssue = value; }
        }
        public Item()
        {
            _id = 0;
            _title = string.Empty;
            _publihser = string.Empty;
            _dateOfIssue = DateTime.MinValue;
        }
        public Item(string title, string publiser, DateTime dateOfIssue)
        {
            _title = title;
            _publihser = publiser;
            _dateOfIssue = dateOfIssue;
        }
        public override string ToString()
        {
            return $"Tytuł: {_title} Wydawdca: {_publihser} Data wydania: {_dateOfIssue}";
        }
        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public abstract string GenerateBarCode();
    }
}
