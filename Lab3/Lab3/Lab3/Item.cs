using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Item
    {
        protected int _id;
        protected string _title;
        protected string _publisher;
        protected DateTime _dateOfIssue;

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public DateTime DateOfIssue { get; set; }

        public Item() 
        {
            _title = "default title";
            _id = 0;
			_publisher = "default publisher";
            _dateOfIssue = DateTime.Now;
        }

        public Item(string title, int id, string publisher, DateTime dateOfIssue) 
        {
            _title = title;
            _id = id;
            _publisher = publisher;
            _dateOfIssue = dateOfIssue;
        }

		public override string ToString()
		{
            return $"Title: {_title}\nId: {_id}\nPublisher: {_publisher}\nDate of issue: {_dateOfIssue}\n\n";
		}

        public void Details()
        {
            Console.WriteLine(ToString());
        }

        public virtual string GenerateBarCode() 
        {
            return "IBC";
        }
	}
}
