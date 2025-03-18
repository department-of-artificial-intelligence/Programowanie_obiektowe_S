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

        public Item(int id, string title, string publisher, DateTime dateOfIssue)
        {
            _id = id;
            _title = title;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }
        public Item(): this(0, string.Empty, string.Empty, new DateTime(0)) {}

        public override string ToString()
        {
            return $"Id: {_id}, Title: {_title}, Publisher: {_publisher}, DateOfIssue: {_dateOfIssue}";
        }

        public void Details()
        {
            Console.WriteLine(this.ToString());
        }

        public abstract string GenerateBarCode();
    }
}
