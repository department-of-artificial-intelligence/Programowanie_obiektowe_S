using Crud.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab4.bll {
	public class FinalGrade : IDisplayable {
		public Subject Subject { get; set; }
		public DateTime Date { get; set; }
		public double Value { get; set; }

		public FinalGrade(Subject subject, double value, DateTime date) {
			Subject = subject;
			Value = value;
			Date = date;
		}

		public override string ToString() {
			string napis = "";

			napis += $"Subject: {Subject} ";
			napis += $"Date: {Date} ";
			napis += $"Value: {Value}";

			return napis;
		}

	}
}
