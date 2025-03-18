using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Item
    {
        private int _id;
        private string _title;
        private string _publisher;
        private DateTime _dateOfIssue;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Publisher { get { return _publisher; } set { _publisher = value; } }
        public DateTime DateOfIssue { get { return _dateOfIssue; } set { _dateOfIssue = value; } }

        public Item()
        {
            _id = 0;
            _title = "nieznany";
            _publisher = "nieznanyp";
            _dateOfIssue = new DateTime(0, 0, 0);
        }
        public Item(string title,int id,string publisher,DateTime dateofIssue)
        {
            _title = title;
            _id=id;
            _publisher = publisher;
            _dateOfIssue = dateofIssue;
        }

        public override string ToString()
        {
            return $"ID: {_id} TITLE: {_title} PUBLISHER: {_publisher} DATE: {_dateOfIssue} ";

        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }
        public abstract string GenerateBarCode();




    }
}
