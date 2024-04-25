using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.BLL
{
	public class Grade
	{
		public string Lesson {  get; set; }
		public DateTime Date { get; set; }
		public double Value { get; set; }

		public Grade() { 
			Lesson = string.Empty;
			Date = DateTime.Now;
			Value = 0;
		}
		public Grade(string lesson, DateTime date, double value)
		{
			Lesson = lesson;
			Date = date;
			Value = value;
		}
	}
}
