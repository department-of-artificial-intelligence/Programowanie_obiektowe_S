using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3 {
    public abstract class Item {

		protected int _id;
		protected string _title;
		protected string _publisher;
		protected DateTime _dateOfIssue;

		public DateTime DateOfIssue {
			get { return _dateOfIssue; }
			set { _dateOfIssue = value; }
		}
		public string Publisher {
			get { return _publisher; }
			set { _publisher = value; }
		}
		public string Title {
			get { return _title; }
			set { _title = value; }
		}
		public int Id {
			get { return _id; }
			set { _id = value; }
		}


        public Item(string title, int id, string publisher, DateTime dateOfIssue) {
            Id = id;
            Title = title;
            Publisher = publisher;
            DateOfIssue = dateOfIssue;
            DateOfIssue = dateOfIssue;
            Publisher = publisher;
            Title = title;
            Id = id;
        }

        public Item(){
        }

        public override string ToString() {
            return
				   $"Id: {this.Id}, " +
				   $"Title: {this.Title}, " +
				   $"Publisher: {this.Publisher}, " +
				   $"Date {this.DateOfIssue.ToString("dd-MM-yyyy")}";
        }

		public void Details() {
			Console.WriteLine(this);
		}

		public abstract string GenerateBarCode();
    }
}
