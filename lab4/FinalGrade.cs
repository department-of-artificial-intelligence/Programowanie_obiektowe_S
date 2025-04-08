using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4 {
	class FinalGrade {

		public Subject Subject { get; set; }
		public DateTime Date { get; set; }
		public double Value { get; set; }

		public FinalGrade(Subject subject, double value, DateTime date) {
			Subject = subject;
			Value = value;
			Date = date;
		}


		public override string ToString() {
			return $"Subject: {this.Subject}, " +
				   $"Date: {this.Date}, " +
				   $"Value: {this.Value}";
		}

	}
}
