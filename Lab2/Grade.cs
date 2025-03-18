using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
	internal class Grade {
		private string _subjectName;
		private double _value;
		private DateTime _date;

		public Grade() {
		}

		public Grade(string subjectName, double value, DateTime date) {
			_subjectName = subjectName;
			_date = date;
			_value = value;
		}

		public string SubjectName {
			get { return _subjectName; }
			set { _subjectName = value; }
		}
		public DateTime Date {
			get { return _date; }
			set { _date = value; }
		}

		public double Value {
			get { return _value; }
			set { _value = value; }
		}

		public override string ToString() {
			return
				   $"nazwa przedmiotu: {this._subjectName}, " +
				   $"data: {this.Date} " +
				   $"wartosc: {this.Value}";
		}

		public void Details() {
			Console.WriteLine(this);
		}

	}
}
